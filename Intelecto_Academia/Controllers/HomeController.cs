using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intelecto_Academia.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index_ajax()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
    }
}
