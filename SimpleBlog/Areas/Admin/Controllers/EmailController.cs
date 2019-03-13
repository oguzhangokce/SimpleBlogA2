using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class EmailController : Controller
    {
        // GET: Admin/Email
        public ActionResult Index()
        {
            return Content("Admin Area Email controller index action");
        }
    }
}