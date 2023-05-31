using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCafe.Models;


namespace MyCafe.DataAccess
{
    public class MyCafeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=ISHANKAM-LT\\SQLEXPRESS; Database=MyCafeDb; User Id=imsa; Password=sa; Encrypt=False;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
