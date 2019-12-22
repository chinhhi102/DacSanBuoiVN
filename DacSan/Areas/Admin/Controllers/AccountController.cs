using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DacSan.Models;
using static DataLibrary.BusinessLogic.UsersProcessor;

namespace DacSan.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (Session["UserID"] != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UsersModel user)
        {
            if (ModelState.IsValid)
            {
                var AdminUser = GetUser(user.Username, user.Password);
                if (AdminUser != null)
                {
                    Session["UserID"] = AdminUser.Id;
                    Session["UserName"] = AdminUser.Username;
                    Session["UserRole"] = AdminUser.Role;
                    return RedirectToAction("Index", "Home");
                }
                else
                    return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}