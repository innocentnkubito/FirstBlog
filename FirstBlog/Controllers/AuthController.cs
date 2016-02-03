using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstBlog.ViewModels;

namespace FirstBlog.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

       public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
       {
           if (!ModelState.IsValid)
               return View(form);

            if(form.Username != "ranbow")
            {
                ModelState.AddModelError("Username", "Username or password is unknown");
                return View(form);
            }

           
           return Content("It is valid");
       }

    }
}
