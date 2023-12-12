using MVCWithEFMF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFMF.Controllers
{
    public class HomeController : Controller
    {
        TestEFContainer testEFContainer = new TestEFContainer();
        public ActionResult Index()
        {
            return View(testEFContainer.Employees);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}