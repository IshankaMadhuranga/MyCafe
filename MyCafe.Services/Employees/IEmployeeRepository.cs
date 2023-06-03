using MyCafe.Models;
using MyCafe.Services.Models;
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
        public Task<IEnumerable<Employee>> AllEmployees();
        public Task<Employee> GetEmployee(int id);
        public void UpdateEmployee(Employee cafe);
        public void DeleteEmployee(Employee cafe);
        
    }
}
