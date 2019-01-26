using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description de l'application MyPOS.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Management()
        {
            ViewBag.Message = "Votre page de gestion.";
            return View();
        }
    }
}