using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Models
{
    public class EmployeeTo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EmployeeGender Gender { get; set; }
        public int CafeId { get; set; }
    }
}
