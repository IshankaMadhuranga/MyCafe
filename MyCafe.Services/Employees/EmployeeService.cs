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
        private readonly MyCafeDbContext _context = new MyCafeDbContext();

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return _context.Employees.Find(employee.Id);  //To do
        }

        public List<Employee> AllEmployees()
        {
            return _context.Employees.OrderByDescending(employee => employee.StartDate).ToList(); //To do
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Remove(employee);
            _context.SaveChanges();
        }

        public void updateEmployee(Employee cafe)
        {
            _context.SaveChanges();
        }
    }
}
