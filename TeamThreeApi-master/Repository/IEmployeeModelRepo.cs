using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamThreeApi.Models;

namespace TeamThreeApi.Repository
{
    public interface IEmployeeModelRepo
    {
        List<EmployeeModelDB> Showall();
        int Insert(EmployeeModelDB employeeModelDB);
        int Delete(int? id);
        int Update(int? id, EmpModel empModel);
    }
}
