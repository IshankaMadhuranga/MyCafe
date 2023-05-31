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

        public MyCafeDbContext(DbContextOptions<MyCafeDbContext> options)
            : base(options)
        {
        }
    }
}
