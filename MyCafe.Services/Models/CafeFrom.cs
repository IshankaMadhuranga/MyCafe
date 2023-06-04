using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Models
{
    public class CafeFrom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalEmployees { get; set; }
        public string Location { get; set; }
        public string Id { get; set; }
    }
}
