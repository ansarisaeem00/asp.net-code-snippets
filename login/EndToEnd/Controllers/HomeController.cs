using EndToEnd;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;

namespace Home.Controllers
{
    public class HomeController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        
        

        public ActionResult Sample()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}