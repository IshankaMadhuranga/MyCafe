using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Services.Employees;

namespace MyCafe.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;

        public EmployeesController(IEmployeeRepository repository)
        {
            _employeeService = repository;
        }

        [HttpGet("{cafeId?}")]
        public IActionResult GetEmployees(int? cafeId)
        {
            var employees = _employeeService.AllEmployees();
            if (cafeId == null)
            {
                return Ok(employees);
            }
            employees = employees.Where(t => t.Cafe?.Id == cafeId).ToList();
            return Ok(employees);
        }
    }
}
