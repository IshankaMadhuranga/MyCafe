using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyCafe.Models;


namespace MyCafe.DataAccess
{
    public class MyCafeDbContext : DbContext, IMyCafeDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Cafe> Cafes { get; set; }

        public MyCafeDbContext(DbContextOptions<MyCafeDbContext> options)
            : base(options)
        {
        }


    }
}

