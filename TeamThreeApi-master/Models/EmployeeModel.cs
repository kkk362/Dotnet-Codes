using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamThreeApi.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double salary { get; set; }
        public int age { get; set; }
        public string city { get; set; }
    }
}
