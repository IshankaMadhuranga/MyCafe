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
        private readonly MyCafeDbContext _context = new MyCafeDbContext();
        public Cafe AddCafe(Cafe cafe)
        {
            _context.Cafes.Add(cafe);
            _context.SaveChanges();

            return _context.Cafes.Find(cafe.Id);
        }

        public List<Cafe> AllCafes()
        {
            return _context.Cafes.ToList();
        }


        public void updateCafe(Cafe cafe)
        {
            _context.SaveChanges();
        }


        public void DeleteCafe(Cafe cafe)
        {
            _context.Remove(cafe);
            _context.SaveChanges();
        }
    }
}
