using MyCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Cafes
{
    public interface ICafeRepository
    {
        public Task<Cafe> AddCafe(Cafe cafe);
        public Task<IEnumerable<Cafe>> AllCafes();

        public Task<Cafe> GetCafe(int id);
        public Task updateCafe(Cafe cafe);
        public Task DeleteCafe(Cafe cafe);
    }
}
