using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Models
{
    public class Cafe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public SqlBinary Logo { get; set; }
        public string Location { get; set; }
        public int EmpId { get; set; }
    }
}
