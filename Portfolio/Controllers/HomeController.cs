using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact page.";

            return View();
        }
        public ActionResult Education()
        {
            ViewBag.Message = "My Education page.";

            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "My Projects page.";

            return View();
        }
        public ActionResult Personal()
        {
            ViewBag.Message = "My Personal Information";

            return View();
        }
    }
}