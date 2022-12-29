using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class ManagersController : Controller
    {
        [Route("/")]//https://localhost:44384/
        [Route("MIndex")]
        [Route("Managers/MIndex")]

        public string  MIndex()
        {
            return "this M Index Page";
        }
    }
}
