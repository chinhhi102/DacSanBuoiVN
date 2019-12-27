using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DacSan.Models;
using DacSan.Areas.Guest.Models;
using static DataLibrary.BusinessLogic.UsersProcessor;

namespace DacSan.Areas.Guest.Controllers
{
    public class AccountController : Controller
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
        // GET: Guest/Account
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
                __construct();
            return View();
        }

        public ActionResult Login()
        {
            if (Session["UserID"] != null)
                __construct();
            if (Session["UserID"] != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginModel user)
        {
            if (ModelState.IsValid)
            {
                var GuestUser = GetUser(user.Username, user.Password);
                if (GuestUser != null)
                {
                    Session["UserID"] = GuestUser.Id;
                    Session["UserName"] = GuestUser.Username;
                    Session["UserRole"] = GuestUser.Role;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Error"] = "Sai tài khoản hoặc mật khẩu";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        public ActionResult Register()
        {
            if (Session["UserID"] != null)
                __construct();
            if (Session["UserID"] != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UsersModel user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var GuestUser = GetUser(user.Username);
                    if (GuestUser == null)
                    {
                        CreateUser(user.Username, user.Password, user.FirstName, user.LastName, user.EmailAddress, user.PhoneNumber, 1);
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        TempData["Error"] = "Tài khoản đã được đăng ký";
                        return RedirectToAction("Register");
                    }
                } catch (Exception ex)
                {
                    TempData["Error"] = "Đăng ký thất bại, Mất kết nối cơ sở dữ liệu";
                    return RedirectToAction("Register");
                }
            }
            return View();
        }

        public ActionResult ResetPassword()
        {
            if (Session["UserID"] != null)
                __construct();
            if (Session["UserID"] == null)
            {
                TempData["Error"] = "Bạn chưa đăng nhập";
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public ActionResult Info()
        {
            if (Session["UserID"] != null)
                __construct();
            if (Session["UserID"] == null)
            {
                TempData["Error"] = "Bạn chưa đăng nhập";
                return RedirectToAction("Login", "Account");
            }
            var GuestUser = GetUser((String)Session["UserName"]);
            var guest = new DacSan.Models.UsersModel(GuestUser);
            return View(guest);
        }

        public ActionResult Logout()
        {
            if (Session["UserID"] != null)
                __construct();
            if (Session["UserID"] == null)
            {
                TempData["Error"] = "Bạn chưa đăng nhập";
                return RedirectToAction("Login", "Account");
            }
            Session.Clear();
            return RedirectToAction("Login");
        }

    }
}