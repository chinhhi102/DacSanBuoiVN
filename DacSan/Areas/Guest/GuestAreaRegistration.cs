using System.Web.Mvc;

namespace DacSan.Areas.Guest
{
    public class GuestAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Guest";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Guest_Default",
                "Guest/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "DacSan.Areas.Guest.Controllers" }
            );

            context.MapRoute(
                "Product",
                "Product/{action}/{categoriesID}/{productID}",
                new { controller = "Product", action = "Details", productID = UrlParameter.Optional }
            );
        }
    }
}