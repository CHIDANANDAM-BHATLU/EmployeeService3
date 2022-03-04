using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeService3.Models;

namespace EmployeeService3.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using(EmployeeEntities employeeEntities = new EmployeeEntities())
            {
                return employeeEntities.Employees.ToList();
            }
        }

        public Employee GetEmployee(int id)
        {
            using(EmployeeEntities employeeEntities = new EmployeeEntities())
            {
                return employeeEntities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
