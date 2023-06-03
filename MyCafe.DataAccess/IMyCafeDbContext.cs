using Microsoft.EntityFrameworkCore;
using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.DataAccess
{
    public interface IMyCafeDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Cafe> Cafes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
