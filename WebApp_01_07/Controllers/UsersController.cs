using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_01_07.Models;

namespace WebApp_01_07.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

       
        [HttpPost]

        public IActionResult UserLogin(Login  login)
        {
            if(login.Username=="Raj" && login.Password=="ss")
            {
                HttpContext.Session.SetString("Uname", login.Username);
                return RedirectToAction("Inbox", "Account");
            }
            else
            {
                ViewBag.msg = "Invalid Username/password";
            }

            return View();
        }
        public IActionResult UserRegistration()
        {
            return View();
        }
        public IActionResult UserShowProfile()
        {
            return View();
        }
        public IActionResult UsereditPrfile()
        {
            return View();
        }
    }
}
