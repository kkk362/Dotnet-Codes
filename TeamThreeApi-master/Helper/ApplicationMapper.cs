using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamThreeApi.Models;

namespace TeamThreeApi.Helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper() {
            CreateMap<EmpModel, EmployeeModelDB>().ReverseMap();
        }
        
    }
}
