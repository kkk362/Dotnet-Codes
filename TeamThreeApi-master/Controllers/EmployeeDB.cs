using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamThreeApi.Models;
using TeamThreeApi.Repository;

namespace TeamThreeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDB : ControllerBase
    {
        private readonly IEmployeeModelRepo employeeModelRepo;
        private readonly IMapper mapper;
        public EmployeeDB(IEmployeeModelRepo employeeModelRepo, IMapper mapper)
        {
            this.employeeModelRepo = employeeModelRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<EmpModel>> ShowAll()
        {
            var data = employeeModelRepo.Showall();
            var w = mapper.Map<List<EmpModel>>(data);
            return w;
        }
        [HttpPost]
        public int insert(EmpModel employeeModelDB)
        {
            var w = mapper.Map<EmployeeModelDB>(employeeModelDB);
            int data = employeeModelRepo.Insert(w);
            return 1;
        }
        [HttpDelete]
        public int delete(int? id)
        {

            var ar = employeeModelRepo.Delete(id);

            return 1;
        }
        [HttpPut]
        public int Update(int? id, EmpModel empModel)
        {

            var ar = employeeModelRepo.Update(id, empModel);

            return 1;
        }
    }
}
