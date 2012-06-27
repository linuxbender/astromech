using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrossCutting.Common.Constant;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Help()
        {
            return View(); 
        }
 
        [HttpGet]
        public ActionResult Contact()
        {
            return View(); 
        }

        [HttpGet]
        public RedirectResult Github()
        {
            return Redirect(StringConstant.BUG_ROUTE); 
        }
    }
}