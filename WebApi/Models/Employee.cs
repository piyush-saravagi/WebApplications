using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Employee
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public int employeePerformanceScore { get; set; }
    }
}