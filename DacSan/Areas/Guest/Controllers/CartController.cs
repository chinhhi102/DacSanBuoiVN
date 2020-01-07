using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DacSan.Models;
using DacSan.Areas.Guest.Models;
using static DataLibrary.BusinessLogic.LoaiSPProcessor;
using static DataLibrary.BusinessLogic.ProductProcessor;
using static DataLibrary.BusinessLogic.OrderDetailProcessor;
using static DataLibrary.BusinessLogic.OrderProcessor;
using static DataLibrary.BusinessLogic.GuestProcessor;
using static DataLibrary.BusinessLogic.UsersProcessor;
using static DataLibrary.BusinessLogic.CartDetailProcessor;
using static DataLibrary.BusinessLogic.CartProcessor;
using DataLibrary.Models;
using DataLibrary.Models.NewFolder1;
using PagedList;

namespace DacSan.Areas.Guest.Controllers
{
    public class CartController : Controller
    {
        Model1 db = new Model1();
        private void __construct()
        {
            ViewBag.Title = "Trang Người dùng";
            try
            {
                if (Session["UserID"] != null)
                {
                    ViewBag.UserID = Session["UserID"];
                    ViewBag.UserName = Session["UserName"];
                    ViewBag.UserRole = Session["UserRole"];
                    var user = LoadOneUser((int)Session["UserID"]);
                    ViewData["user"] = user;
                    List<ItemModel> list = new List<ItemModel>();
                    var listCart = LoadCartDetailByCartID((int)Session["CartID"]);
                    foreach (CartDetailModel cd in listCart)
                    {
                        var product = LoadOneProduct(cd.SanPhamID);
                        if (product != null)
                        {
                            ItemModel item = new ItemModel() { SL = cd.SL, NgayThem = cd.NgayThem, Product = new DacSan.Models.ProductModel(product) };
                            list.Add(item);
                        }
                    }
                    Session["cart"] = list;
                }

                List<tbl_TinTuc> listtintuc = db.tbl_TinTuc.ToList();
                ViewData["listTinTuc"] = listtintuc;

                var loaisp = LoadLoaiSP(12);
                ViewData["loaisp"] = loaisp;
                foreach (LoaiSPModel loai in (IEnumerable<LoaiSPModel>)ViewData["loaisp"])
                {
                    var listsp = LoadProductByCate(loai.LoaiSPID, 6);
                    ViewData[loai.LoaiSPID.ToString()] = listsp;
                }
                if (Session["cart"] != null)
                {
                    ViewData["NumCart"] = ((List<ItemModel>)Session["cart"]).Count;
                }
                else
                {
                    ViewData["NumCart"] = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void __LoadCart()
        {
            if (Session["UserID"] != null)
            {
                var check = LoadOneCartByUser((int)Session["UserID"]);
                int GioHangID;
                if (check == null)
                {
                    GioHangID = CreateCart((int)Session["UserID"]);
                }
                else
                {
                    GioHangID = check.GioHangID;
                }
                RemoveAllCartDetail(GioHangID);
                if (Session["cart"] != null)
                {
                    List<ItemModel> cart = (List<ItemModel>)Session["cart"];
                    foreach (ItemModel item in cart)
                    {
                        CreateCartDetail(item.Product.ProductID, item.SL, item.Product.DonGia, GioHangID, item.NgayThem);
                    }
                }
            }
        }
                // GET: Guest/Cart
        public ActionResult Index(int id = -1)
        {
            if (id != -1)
            {
                int sl = 1;
                if (Session["cart"] == null)
                {
                    List<ItemModel> cart = new List<ItemModel>();
                    var sp = new DacSan.Models.ProductModel(LoadOneProduct(id));
                    ItemModel item = new ItemModel() { Product = sp, SL = sl, NgayThem = DateTime.Now};
                    cart.Add(item);
                    Session["cart"] = cart;
                }
                else
                {
                    List<ItemModel> cart = (List<ItemModel>)Session["cart"];
                    int index = isExist(id);
                    if (index != -1)
                    {
                        cart[index].SL += sl;
                    }
                    else
                    {
                        var sp = new DacSan.Models.ProductModel(LoadOneProduct(id));
                        ItemModel item = new ItemModel() { Product = sp, SL = sl, NgayThem = DateTime.Now };
                        cart.Add(item);
                    }
                    Session["cart"] = cart;
                }
                __LoadCart();
            }
            __construct();
            return View();
        }

        public ActionResult InfoGuest()
        {
            __construct();
            if (Session["cart"] == null || ((List<ItemModel>)Session["cart"]).Count == 0)
            {
                TempData["Error"] = "Không có sản phẩm nào";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InfoGuest(InfoGuestModel info)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int KhachHangID;
                    int loai;
                    if (Session["UserID"] == null)
                    {
                        loai = 1;
                        KhachHangID = CreateGuest(info.HoTen, info.Email, info.SDT, info.SoNha, info.Duong, info.Xa, info.Tinh, info.huyen);
                    }
                    else
                    {
                        loai = 2;
                        KhachHangID = (int)Session["UserID"];
                    }
                    var DonHangID = CreateOrder(KhachHangID, loai, 1);
                    foreach (ItemModel item in (List<ItemModel>)Session["cart"])
                    {
                        CreateOrderDetail(item.Product.ProductID, item.SL, item.Product.DonGia, DonHangID, DateTime.Now);
                    }
                    return View("InfoPay");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    TempData["Error"] = "Mua thật bại, Mất kết nối cơ sở dữ liệu";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                return View();
            }
        }
        public ActionResult InfoPay()
        {
            __construct();
            if (Session["cart"] == null || ((List<ItemModel>)Session["cart"]).Count == 0)
            {
                TempData["Error"] = "Không có sản phẩm nào";
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Complete()
        {
            __construct();
            if (Session["cart"] == null || ((List<ItemModel>)Session["cart"]).Count == 0)
            {
                TempData["Error"] = "Không có sản phẩm nào";
                return RedirectToAction("Index");
            }
            Session["cart"] = null;
            __LoadCart();
            __construct();
            return View();
        }

        public ActionResult Remove(int id)
        {
            List<ItemModel> cart = (List<ItemModel>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            __construct();
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<ItemModel> cart = (List<ItemModel>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID.Equals(id))
                    return i;
            return -1;
        }
    }
}