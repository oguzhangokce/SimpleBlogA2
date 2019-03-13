using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
           if (!ModelState.IsValid)
            {
                return View(form);
            }

           if (form.UserName != "username")
            {
                ModelState.AddModelError("UserName", "User doesn't exist.");

            }
            return Content("The form is valid");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AuthRegister form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            
            return Content(String.Format("Kayıt baraşıyla alındı.<br /><br />Öğrenci NO: {0}<br />Öğrenci Adı : {1} {2}<br />Email: {3}", form.StudentNumber, form.StudentName, form.StudentSurname, form.StudentEmail));
        }
    }
}