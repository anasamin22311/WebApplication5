using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ ID =1,Name="anas",Email="anasamin22311",Departmet="Bio"},
                new Employee(){ ID =2,Name="Emo",Email="Emo1998",Departmet="teaching"},
                new Employee(){ ID =3,Name="Ahmed",Email="Right1999",Departmet="Medecine"}
            };

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee getEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e=>e.ID==id);
        }
    }
}
