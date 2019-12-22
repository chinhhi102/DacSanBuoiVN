using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.UsersProcessor;

namespace DacSan.Controllers
{
    public class HomeController : Controller
    {
        // Index
        public ActionResult Index()
        {
            return View();
        }
        // About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        // Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}