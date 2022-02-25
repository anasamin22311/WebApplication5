using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Dtos.Employee;
using WebApplication5.Models;
using WebApplication5.ViewModels;

namespace WebApplication5.Controllers
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
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("details", new { id = newEmployee.ID });
            }
            return View();
        }
    }
}
