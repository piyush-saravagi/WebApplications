using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        Models.Employee[] employeeArray = new Models.Employee[] {
            new Models.Employee{ Name = "Piyush", Id = 1, employeePerformanceScore = 100},
            new Models.Employee{ Name = "Keegan", Id = 2, employeePerformanceScore = 100},
            new Models.Employee{ Name = "Jill", Id = 3, employeePerformanceScore = 100},
            new Models.Employee{ Name = "Mike", Id = 4, employeePerformanceScore = 100},
        };

        // GET: api/employees
        public IEnumerable<Models.Employee> Get()
        {
            return employeeArray;
        }

        // GET: api/student/5
        public Models.Employee Get(int id)
        {
            for (int i = 0; i < employeeArray.Length; i++)
            {
                if (employeeArray[i].Id == id)
                {
                    return employeeArray[i];
                }
            }
            throw new KeyNotFoundException();
        }

        // POST: api/student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/student/5
        public void Delete(int id)
        {
        }
    }
}
