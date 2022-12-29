using TeamThreeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamThreeApi.DataAccessLayer;
using TeamThreeApi.Repository;

namespace TeamThreeApi.Repository
{
    public class EmployeeModelRepo : IEmployeeModelRepo
    {
        private readonly DataAccessLayerAPI dataAccessLayerAPI;

        public EmployeeModelRepo(DataAccessLayerAPI dataAccessLayerAPI)
        {
            this.dataAccessLayerAPI = dataAccessLayerAPI;
        }
        public List<EmployeeModelDB> Showall()
        {
            var ar = dataAccessLayerAPI.Employee.ToList();
            return ar;
        }
        public int Delete(int? id)
        {
            var a = dataAccessLayerAPI.Employee.FirstOrDefault(x => x.EmpId == id);
            if (a != null)
            {
                dataAccessLayerAPI.Employee.Remove(a);
                dataAccessLayerAPI.SaveChanges();
            }
            return 1;
        }

        public int Insert(EmployeeModelDB employeeModelDB)
        {
            dataAccessLayerAPI.Add(employeeModelDB);
            dataAccessLayerAPI.SaveChanges();
            return 1;
        }
        public int Update(int? id, EmpModel empModel)
        {
            var a = dataAccessLayerAPI.Employee.FirstOrDefault(x => x.EmpId == id);
            if (a != null)
            {
                a.age = empModel.age;
                a.city = empModel.city;
                a.EmpName = empModel.EmpName;
                a.salary = empModel.salary;
                dataAccessLayerAPI.SaveChanges();

            }

            return 1;
        }


    }
}