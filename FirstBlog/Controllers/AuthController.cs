using System.Web.Mvc;
using System.Web.Security;
using FirstBlog.ViewModels;

namespace FirstBlog.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }

       public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
       {
           if (!ModelState.IsValid)
               return View(form);

           FormsAuthentication.SetAuthCookie(form.Username,true);
           
           if (!string.IsNullOrWhiteSpace(returnUrl))
               return Redirect(returnUrl);
           else
           {
               return RedirectToRoute("home");
           }
       }

    }
}
