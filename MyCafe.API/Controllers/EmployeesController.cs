using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Services;

namespace MyCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;

        public EmployeesController(IEmployeeRepository repository)
        {
            _employeeService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetEmployees(int? id)
        {
            var employees = _employeeService.AllEmployees();
            if (id == null)
            {
                return Ok(employees);
            }
            employees = employees.Where(t => t.Id == id).ToList();
            return Ok(employees);
        }
    }
}
