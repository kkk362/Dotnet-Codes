using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication53_CallApi.Controllers
{
    public class MyEmpController : Controller
    {
        public IActionResult showAllEMployee()
        {
            return View();
        }
    }
}
