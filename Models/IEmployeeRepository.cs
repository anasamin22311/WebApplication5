using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IEmployeeRepository
    {
        Employee getEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
