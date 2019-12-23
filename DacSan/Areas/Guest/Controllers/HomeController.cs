﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DacSan.Areas.Guest.Controllers
{
    public class HomeController : Controller
    {
        private void __construct()
        {
            ViewBag.Title = "Trang Quản Trị";
            if (Session["UserID"] != null)
            {
                ViewBag.UserID = Session["UserID"];
                ViewBag.UserName = Session["UserName"];
                ViewBag.UserRole = Session["UserRole"];
            }
        }

        // GET: Home
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
                __construct();
            return View();
        }

        // GET: Home/Tutorial
        public ActionResult Tutorial()
        {
            return View();
        }

        public ActionResult Introduct()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}