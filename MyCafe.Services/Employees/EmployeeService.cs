using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCafe.DataAccess;
using MyCafe.Models;

namespace MyCafe.Services.Employees
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly IMyCafeDbContext _context;
        public EmployeeService(IMyCafeDbContext dbContext )
        {
            _context = dbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
           await _context.SaveChangesAsync(new CancellationToken());

            return _context.Employees.Find(employee.Id);  //To do
        }

        public List<Employee> AllEmployees()
        {
            return _context.Employees.OrderByDescending(employee => employee.StartDate).ToList(); //To do
        }

        public async void DeleteEmployee(Employee employee)
        {
            //_context.Remove(employee);
           await _context.SaveChangesAsync(new CancellationToken());
        }

        public async void updateEmployee(Employee cafe)
        {
           await _context.SaveChangesAsync(new CancellationToken());
        }
    }
}
