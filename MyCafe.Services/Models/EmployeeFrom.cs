using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Models
{
    public class EmployeeFrom
    { 
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public EmployeeGender Gender { get; set; }
        public int DaysWorked { get; set;}
        public int CafeId { get; set; }
        public string CafeName { get; set; }
    }
}
