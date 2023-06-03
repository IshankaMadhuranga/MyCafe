using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Models;
using MyCafe.Services.Employees;
using MyCafe.Services.Models;

namespace MyCafe.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _service;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepository repository, IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetEmployee")]
        public async Task<ActionResult<EmployeeFrom>> GetEmployee(int id)
        {
            var employee =await _service.GetEmployee(id);

            if (employee is null)
            {
                return NotFound();
            }

            var mappedEmployee = _mapper.Map<EmployeeFrom>(employee);

            return Ok(mappedEmployee);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<EmployeeFrom>>> GetEmployees([FromQuery] string? cafe)
        {
            var employees =await _service.AllEmployees();
            var mappedEmployees = _mapper.Map<ICollection<EmployeeFrom>>(employees);

            if (string.IsNullOrWhiteSpace(cafe))
            {
                return Ok(mappedEmployees);
            }
            mappedEmployees = mappedEmployees.Where(t => t.CafeName == cafe).ToList();
            return Ok(mappedEmployees);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeFrom>> CreateEmployee(EmployeeTo employee)
        {
            var employeeEntity = _mapper.Map<Employee>(employee);
            var newEmployee = await _service.AddEmployee(employeeEntity);

            var newEmployeeForReturn = _mapper.Map<EmployeeFrom>(newEmployee);

            return CreatedAtRoute("GetEmployee", newEmployeeForReturn);
        }
    }
}
