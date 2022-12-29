using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    [Route("Mytest")]
    public class TestController : Controller
    {
        //Test/Index
        [Route("showall")]
        [Route("All")]
        [Route("Display")]
        public string  ShowAllTest()
        {
            return "this is Test Index Page";
        }
        //https://localhost:44384/mytest/search
        [Route("search")]
        public string Search()
        {
            return "this is Test search Page";
        }
        //   this is Test search Page1
        //https://localhost:44384/mytest/searchbyid
        //https://localhost:44384/mytest/searchbyid/101
        [Route("searchbyId/{id?}")]
        public string SearchbyId(int id)
        {
            return "this is Test search Page"+id;
        }
        [Route("Contact")]
        public string Contactus()
        {
            return "this is Contact Us Page";
        }

        //https://localhost:44384/contact1
        [Route("~/Contact1")]
        public string Contactus1()
        {
            return "this is Contactus1 Us Page";
        }

    }
}
