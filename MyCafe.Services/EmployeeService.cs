using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCafe.DataAccess;

namespace MyCafe.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly MyCafeDbContext _context = new MyCafeDbContext();
        public List<Employee> AllEmployees()
        {
            var employees = _context.Employees.ToList();
            return employees; ;
        }

    }
}
