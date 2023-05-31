namespace MyCafe.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public EmployeeGender Gender { get; set; }
        public DateTime StartDate { get; set; }
    }
}