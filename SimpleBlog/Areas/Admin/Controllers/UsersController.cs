using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
       

        public ActionResult Index()
        {
            return Content("Admin Area Users Controller Index Action");
        }


        public ActionResult New()
        {
            return Content("Admin Area Users Controller New Action");
        }

        public ActionResult Edit(int id=0)
        {
            return Content("Admin Area Users Controller Edit Action. Id value " + id.ToString());
        }

        public ActionResult Delete(int id=0)
        {
            return Content("Admin Area Users Controller Delete Action. Id for delete : " + id.ToString());
        }


    }
}