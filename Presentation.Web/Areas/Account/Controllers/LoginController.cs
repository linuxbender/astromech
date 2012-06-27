using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrossCutting.Common.Constant;

namespace Presentation.Web.Areas.Account.Controllers
{   
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
            return RedirectToAction(ActionConstant.SIGNUP);
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            // Bug in the Razor View Engine in the MVC 3 - short route def - looking in the wrong view folder
            // ToDo Review - create controller base class or decorate the mvc controller with a extenchen
            if (!this.ControllerContext.RouteData.DataTokens.ContainsKey(StringConstant.BUG_ROUTE))
            {
                this.ControllerContext.RouteData.DataTokens.Add(StringConstant.BUG_ROUTE, AreaConstant.ACCOUNT);
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