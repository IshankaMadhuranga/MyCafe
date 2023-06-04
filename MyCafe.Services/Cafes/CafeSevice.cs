using Microsoft.EntityFrameworkCore;
using MyCafe.DataAccess;
using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Cafes
{
    public class CafeSevice : ICafeRepository
    {
        private readonly IMyCafeDbContext _context;
        public CafeSevice(IMyCafeDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<Cafe> AddCafe(Cafe cafe)
        {
            await _context.Cafes.AddAsync(cafe);
            await _context.SaveChangesAsync();

            return await GetCafe(cafe.Id);
        }

        public async Task<IEnumerable<Cafe>> AllCafes()
        {
            return await _context.Cafes.Include(cafe => cafe.Employees).OrderByDescending(cafe => cafe.Employees.Count).ToListAsync();
        }

        public async Task<Cafe> GetCafe(int id)
        {
            return await _context.Cafes.Include(cafe => cafe.Employees).FirstOrDefaultAsync(cafe => cafe.Id == id);
        }

        public async Task updateCafe(Cafe cafe)
        {
            await _context.SaveChangesAsync();
        }


        public async Task DeleteCafe(Cafe cafe)
        {
            _context.Cafes.Remove(cafe);
            await _context.SaveChangesAsync();
        }
    }
}
