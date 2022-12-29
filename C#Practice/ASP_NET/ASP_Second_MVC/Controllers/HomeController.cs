using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Second_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your project description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page,get in touch with us.";

            return View();
        }
    }
}