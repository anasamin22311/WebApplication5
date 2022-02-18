using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Dtos.Employee;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeDetailsViewModel
    {
        public EmployeeDto Employee { get; set; }
        public String PageTitle { get; set; }
    }
}
