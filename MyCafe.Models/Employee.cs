using System.ComponentModel.DataAnnotations;

namespace MyCafe.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }
        [Required]
        public EmployeeGender Gender { get; set; }
        public DateTime StartDate { get; set; }

        public Cafe? Cafe { get; set; }
    }
}