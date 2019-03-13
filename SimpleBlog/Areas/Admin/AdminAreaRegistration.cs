using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}/{userid}",
                new {controller="Users" ,action = "Index", id = UrlParameter.Optional,userid=UrlParameter.Optional }
            );
        }
    }
}