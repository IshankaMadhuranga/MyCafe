using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyCafe.Models;


namespace MyCafe.DataAccess
{
    public class MyCafeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Cafe> Cafes { get; set; }

        //public MyCafeDbContext(DbContextOptions<MyCafeDbContext> options)
        //    : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=ISHANKAM-LT\\SQLEXPRESS; Database=MyCafeDb; User Id=imsa; Password=sa; Encrypt=False;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee[] {
                new Employee { Id = 1, Name = "Ishma Madu", Email="ishmaemail@gmail.com",Gender=EmployeeGender.Male,  Phone="0771234567", StartDate=DateTime.Now},
                new Employee { Id = 2, Name = "Peshani Bandara", Email="ishmaemail@gmail.com",Gender=EmployeeGender.Female,  Phone="0711234567", StartDate=DateTime.Now},
                new Employee { Id = 3, Name = "Chaminda Herath", Email = "ishmaemail@gmail.com",Gender=EmployeeGender.Male, Phone = "0751234567", StartDate = DateTime.Now},
                new Employee { Id = 4, Name = "Denesh Manjula", Email = "ishmaemail@gmail.com",Gender=EmployeeGender.Male, Phone = "0761234567", StartDate = DateTime.Now}
            });

            modelBuilder.Entity<Cafe>().HasData(new Cafe[]
            {
                new Cafe
                {
                    Id = 1,
                    Name="Chinese Cafe",
                    Description="Chinees taste",
                    Location="Kollupitiya",
                    EmplId=2,
                },
                new Cafe
                {
                    Id = 2,
                    Name="Indian Cafe",
                    Description="Indian taste",
                    Location="Wellawatte",
                    EmplId=1,
                },
                new Cafe
                {
                    Id = 3,
                    Name="Sri Lankan Cafe",
                    Description="Local taste",
                    Location="Galle",
                    EmplId=4,
                },
            });
        }
    }
}
