using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Employees
{
    public interface IEmployeeRepository
    {
        public Employee AddEmployee(Employee cafe);
        public List<Employee> AllEmployees();

        public void updateEmployee(Employee cafe);
        public void DeleteEmployee(Employee cafe);
        
    }
}
