using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Piss.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The story behind PISS.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch.";

            return View();
        }

        public ActionResult Documentation()
        {
            ViewBag.Message = "Become and Expert PISSer by reading the guidelines below. Pictures included!";
            return View();
        }
        
    }
}