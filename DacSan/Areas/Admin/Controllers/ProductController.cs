using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary.Models;
using static DataLibrary.BusinessLogic.ProductProcessor;
using static DataLibrary.BusinessLogic.LoaiSPProcessor;
using static DataLibrary.BusinessLogic.DiaChiProcessor;

namespace DacSan.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            var products = LoadProducts();
            ViewBag.Title = "Quản Lý Sản Phẩm";
            ViewData["products"] = products;

            return View();
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            var loaisp = LoadLoaiSP();
            ViewData["loaisp"] = loaisp;
            var diachi = LoadDiaChi();
            ViewData["diachi"] = diachi;
            ViewBag.Title = "Thêm Sản Phẩm";
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            try
            {
                CreateProduct(product.TenSP, product.MoTa, product.LoaiSPID, product.DiaChiID);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
