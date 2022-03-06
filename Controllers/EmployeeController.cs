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
        public IEnumerable<Employee> GetEmployee()
        {
            using(EmployeeEntities ee = new EmployeeEntities())
            {
                return ee.Employees.ToList();
            }
        }
        
        public Employee GetEmployee(int id)
        {
            using(EmployeeEntities ef = new EmployeeEntities())
            {
                return ef.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
