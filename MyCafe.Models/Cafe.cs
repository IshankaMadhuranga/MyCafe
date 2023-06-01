using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Models
{
    public class Cafe
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        //public SqlBinary Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Location { get; set; }
        public int EmplId { get; set; }
    }
}
