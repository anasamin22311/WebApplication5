using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dtos.Employee;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
        [Route("[controller]/[action]")]
    public class HomeController:Controller
    {
        private  readonly  IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public HomeController(
            IMapper mapper,
            IEmployeeRepository employeeRepository
            )
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;

    }
        //[Route("~/Home")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);        
        }
        [Route("{id?}")]
        public ViewResult Details(int? id)
        {
            var employee = _employeeRepository.getEmployee(id ?? 1);
            var dto = _mapper.Map<EmployeeDto>(employee);
            var vm  = _mapper.Map<HomeDetailsViewModel>(dto);
            return View(vm);
        }
    }
}
