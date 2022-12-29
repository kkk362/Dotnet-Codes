using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_01_07.Controllers
{
    public class AccountController : Controller
    {   public IActionResult SignOutPage()
        {    return RedirectToAction("Login");
           
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Inbox()
        {
           
            if(HttpContext.Session.GetString("Uname")!= null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Uname");
            }
            else
            {
                return RedirectToAction("UserLogin", "Users");
            }

                return View();
        }
        public IActionResult EditProfile()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}
