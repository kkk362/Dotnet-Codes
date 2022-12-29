using Gmail.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Gmail.Controllers
{
    public class EmpInfoController : Controller
    {
        List<Employee> lst = new List<Employee>()
        {
            new Employee{Id=101,Name="Raj",Address="A-190",Salary=23423424},
              new Employee{Id=102,Name="kumar",Address="A-190",Salary=23423424},
                new Employee{Id=103,Name="ablay",Address="b-190",Salary=423424}
        };
        public IActionResult ShowAllEmp()
        {
            ViewData["data"] = lst;
            return View();
        }
        public IActionResult Display()
        {
            ViewBag.AllEmp = lst;
            return View();
        }
    }
}
