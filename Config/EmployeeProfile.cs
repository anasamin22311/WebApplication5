using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dtos.Employee;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Config
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap()
                .ForMember(d => d.Departmet, opt => opt.MapFrom(x => x.DepartmetName));
                ;


            CreateMap<EmployeeDto, HomeDetailsViewModel>()
                 .ForMember(d => d.Employee, opt => opt.MapFrom(x => x))
                 .ForMember(d => d.PageTitle, opt => opt.MapFrom(x => "EmplyeeDetails"))
                 ;



        }
    }
}
