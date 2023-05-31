using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        public List<Employee> AllEmployees()
        {
            var employees = new List<Employee>();
            return employees; ;
        }

    }
}
