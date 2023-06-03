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
        public Task<Employee> AddEmployee(Employee employee);
        public List<Employee> AllEmployees();

        public void updateEmployee(Employee cafe);
        public void DeleteEmployee(Employee cafe);
        
    }
}
