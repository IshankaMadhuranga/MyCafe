﻿using System.ComponentModel.DataAnnotations;

namespace MyCafe.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [MaxLength(8)]
        public string Phone { get; set; }
        [Required]
        public EmployeeGender Gender { get; set; }
        public DateTime StartDate { get; set; }
        public int CafeId { get; set; }
        public virtual Cafe Cafe { get; set; }
    }
}