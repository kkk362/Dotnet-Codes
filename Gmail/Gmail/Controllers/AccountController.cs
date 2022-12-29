using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gmail.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            ViewData["Username"] = "Raj";
           //dynamic property
            ViewBag.name = "Kumar";
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
