using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamThreeApi.Models;

namespace TeamThreeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpInfo : ControllerBase
    {
        static List<EmployeeModel> list = new List<EmployeeModel>()
        {
            new EmployeeModel{EmpId=101, EmpName="ABC",age=21, salary=12000000,city="Varanasi"},
            new EmployeeModel{EmpId=102, EmpName="DEF",age=25, salary=500000,city="MUMBAI"},
            new EmployeeModel{EmpId=103, EmpName="GHI",age=26, salary=900000,city="Goa"},
            new EmployeeModel{EmpId=104, EmpName="JKL",age=28, salary=1200000,city="Bhopal"}
        };
        [HttpGet]
        public ActionResult<List<EmployeeModel>> Showall()
        {
            return list;
        }
        [HttpPost]
        public ActionResult<List<EmployeeModel>>Insert(EmployeeModel model)
        {
            list.Add(model);
            return list;
        }
        [HttpDelete]
        public ActionResult<List<EmployeeModel>>Delete(int ? id)
        {
            var ar = list.FirstOrDefault(x => x.EmpId == id);
                if (ar != null)
            {
                list.Remove(ar);
            }
            return list;
        }
        [HttpPut]
        public ActionResult<List<EmployeeModel>>Update(int id, EmployeeModel model)
        {
            var ar = list.FirstOrDefault(x => x.EmpId == id);
            if(ar!= null)
            {
                ar.EmpName = model.EmpName;
                ar.age = model.age;
                ar.city = model.city;
                ar.salary = model.salary;
            }
            return list;
        }
    }
}
