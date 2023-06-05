using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCafe.DataAccess;
using MyCafe.Models;
using MyCafe.Services.Models;

namespace MyCafe.Services.Employees
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly IMyCafeDbContext _context;
        public EmployeeService(IMyCafeDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.StartDate = DateTime.Now;
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();

            return await GetEmployee(employee.Id);
        }

        public async Task<IEnumerable<Employee>> GetCafeEmployees(int id)
        {
            var data = await _context.Employees.Where(emp => emp.CafeId == id).Include(e => e.Cafe).OrderBy(employee => employee.StartDate).ToListAsync(); //To do
            return data;
        }

        public async Task<IEnumerable<Employee>> AllEmployees()
        {
            return await _context.Employees.OrderBy(employee => employee.StartDate).Include(e => e.Cafe).ToListAsync(); //To do
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.Include(e => e.Cafe).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _context.SaveChangesAsync();
        }
    }
}
