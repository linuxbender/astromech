using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Web.Areas.Account.Controllers
{    
    [RequireHttps]    
    public class LoginController : Controller
    {
        //
        // GET: /Account/Login/
        public LoginController()
        {
            // TODO: Inject user entity
        }
        //
        // GET: /Account/UserLogin/
        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("SignIn");
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            // Bug in the Razor View Engine in the MVC 3 - short route def - looking in the wrong view folder
            if (!this.ControllerContext.RouteData.DataTokens.ContainsKey("area"))
            {
                this.ControllerContext.RouteData.DataTokens.Add("area", "Account");
            }
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(FormCollection collection)
        {
            try
            {
                // TODO: go to user page

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(FormCollection collection)
        {
            try
            {
                // TODO: go to user page

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
    }
}