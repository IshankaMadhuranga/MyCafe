using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Services.Employees;
using MyCafe.Services.Models;

namespace MyCafe.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepository repository, IMapper mapper)
        {
            _employeeService = repository;
            _mapper = mapper;
        }

        [HttpGet("{cafe?}")]
        public ActionResult<ICollection<EmployeeDto>> GetEmployees(string? cafe)
        {
            var employees = _employeeService.AllEmployees();
            var mappedEmployees = _mapper.Map<ICollection<EmployeeDto>>(employees);

            if (string.IsNullOrWhiteSpace(cafe))
            {
                return Ok(mappedEmployees);
            }
            mappedEmployees = mappedEmployees.Where(t => t.CafeName == cafe).ToList();
            return Ok(mappedEmployees);
        }
    }
}
