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
            _context.Cafes.Add(cafe);
            await _context.SaveChangesAsync(new CancellationToken());

            return _context.Cafes.Find(cafe.Id);
        }

        public List<Cafe> AllCafes()
        {
            return _context.Cafes.ToList();
        }


        public async void updateCafe(Cafe cafe)
        {
            await _context.SaveChangesAsync(new CancellationToken());
        }


        public async void DeleteCafe(Cafe cafe)
        {
            //_context.Remove(cafe);
            await _context.SaveChangesAsync(new CancellationToken());
        }
    }
}
