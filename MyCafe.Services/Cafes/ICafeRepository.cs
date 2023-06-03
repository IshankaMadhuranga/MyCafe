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
        public List<Cafe> AllCafes();

        public void updateCafe(Cafe cafe);
        public void DeleteCafe(Cafe cafe);
    }
}
