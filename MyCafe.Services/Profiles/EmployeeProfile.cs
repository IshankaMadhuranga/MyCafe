using AutoMapper;
using MyCafe.Models;
using MyCafe.Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Services.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeFrom>().ForMember(dest => dest.CafeName, opt => opt.MapFrom(src => (src.Cafe != null) ? src.Cafe.Name : ""))
                .ForMember(dest => dest.DaysWorked, opt => opt.MapFrom(src => (DateTime.Now - src.StartDate).TotalDays));
            CreateMap<EmployeeTo, Employee>();
        }
    }
}
