using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services
{
    public interface IEmployeeRepository
    {
        public List<Employee> AllEmployees();
    }
}
