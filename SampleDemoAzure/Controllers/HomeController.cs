using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleDemoAzure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sai Application. version 2 change,version 3";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sai Application.";

            return View();
        }
    }
}