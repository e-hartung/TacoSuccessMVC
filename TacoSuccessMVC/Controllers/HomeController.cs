using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TacoSuccessMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little bit about us...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Prescott Lerch (Owner)";

            return View();
        }

        public ActionResult PlaceOrders()
        {
            return View();
        }

        public ActionResult MainMenu()
        {
            return View();
        }

        public ActionResult Sides()
        {
            return View();
        }

        public ActionResult KidsMeals()
        {
            return View();
        }

        public ActionResult Beverages()
        {
            return View();
        }
    }
}