using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razon_Act5_6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Registration()
        {

            return View();
        }
        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Employee()
        {

            return View();
        }
    }
}
