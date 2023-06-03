using AutoMapper;
using MyCafe.Models;
using MyCafe.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Profiles
{
    public class CafeProfile : Profile
    {
        public CafeProfile()
        {
            CreateMap<Cafe, CafeDto>().ForMember(dest => dest.TotalEmployees, opt => opt.MapFrom(src => src.Employees.Count))
                .ForMember(dest=>dest.Id,opt=>opt.MapFrom(src=>$"UI{src.Id}"));
        }
    }
}
