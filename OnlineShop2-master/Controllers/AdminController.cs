using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    [Route("{action}/{controller}")]  //https://localhost:44384/index/admin
    public class AdminController : Controller
    {
      //  https://localhost:44384/admin/index
       // [Route("{action}")]     
        public string  Index()
        {
            return "This is Admin Index";
        }
    }
}
