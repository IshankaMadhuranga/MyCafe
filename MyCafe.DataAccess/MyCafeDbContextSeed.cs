using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.DataAccess
{
    public static class MyCafeDbContextSeed
    {


        public static async Task SeedAsync(MyCafeDbContext db)
        {
            await SeedCafeData(db);
            await SeedEmployeeData(db);

        }
        private static async Task SeedCafeData(MyCafeDbContext db)
        {
            db.Database.EnsureCreated();
            if (!db.Cafes.Any())
            {
                var seedCafe = new List<Cafe>{

                    new Cafe
                    {
                        Name="Chinese Cafe",
                        Description="Chinees taste",
                        Location="Kollupitiya",
                    },
                    new Cafe
                    {
                        Name="Indian Cafe",
                        Description="Indian taste",
                        Location="Wellawatte",
                    },
                    new Cafe
                    {
                        Name="Sri Lankan Cafe",
                        Description="Local taste",
                        Location="Galle",
                    },
                };
                db.Cafes.AddRange(seedCafe);

               
                await db.SaveChangesAsync();

            }
        }
        private static async Task SeedEmployeeData(MyCafeDbContext db)
        {
            if (!db.Employees.Any())
            {
                var seedEmployees = new List<Employee> {
                new Employee {  Name = "Ishma Madu", Email="ishmaemail@gmail.com",Gender=EmployeeGender.Male,CafeId=1,  Phone="0771234567", StartDate=DateTime.Now},
                new Employee { Name = "Peshani Bandara", Email="ishmaemail@gmail.com",Gender=EmployeeGender.Female,CafeId=3, Phone = "0711234567", StartDate=DateTime.Now},
                new Employee { Name = "Chaminda Herath", Email = "ishmaemail@gmail.com",Gender=EmployeeGender.Male,CafeId=2,   Phone = "0751234567", StartDate = DateTime.Now},
                new Employee { Name = "Denesh Manjula", Email = "ishmaemail@gmail.com",Gender=EmployeeGender.Male,CafeId=1, Phone = "0761234567", StartDate = DateTime.Now}
            };
                db.Employees.AddRange(seedEmployees);
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            }


        }


    }
}
