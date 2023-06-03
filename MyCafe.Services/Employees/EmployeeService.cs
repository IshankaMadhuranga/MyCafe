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
            try
            {
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
           

            return await GetEmployee(employee.Id);
        }

        public async Task<IEnumerable<Employee>> AllEmployees()
        {
            return await _context.Employees.OrderByDescending(employee => employee.StartDate).ToListAsync(); //To do
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async void UpdateEmployee(Employee cafe)
        {
            await _context.SaveChangesAsync();
        }
    }
}
