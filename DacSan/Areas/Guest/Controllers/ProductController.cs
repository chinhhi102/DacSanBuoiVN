using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DacSan.Areas.Guest.Controllers
{
    public class ProductController : Controller
    {
        private void __construct()
        {
            ViewBag.Title = "Trang Người dùng";
            if (Session["UserID"] != null)
            {
                ViewBag.UserID = Session["UserID"];
                ViewBag.UserName = Session["UserName"];
                ViewBag.UserRole = Session["UserRole"];
            }
        }
        // GET: Product
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
                __construct();
            return View();
        }
    }
}