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
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "DacSan.Guest.Controllers" }
            );
        }
    }
}