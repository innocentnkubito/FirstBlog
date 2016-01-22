using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstBlog.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

       public ActionResult Login()
        {
            return Content("Login!");
        }

    }
}
