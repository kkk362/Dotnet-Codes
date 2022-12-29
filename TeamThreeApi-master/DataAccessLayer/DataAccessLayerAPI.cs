using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamThreeApi.Models;

namespace TeamThreeApi.DataAccessLayer
{
    public class DataAccessLayerAPI:DbContext
    {
        public DataAccessLayerAPI(DbContextOptions<DataAccessLayerAPI> option) : base(option)
        {

        }
        public DbSet<EmployeeModelDB> Employee { get; set; }
    }
}
