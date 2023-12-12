using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithEFCF9.Models;

namespace MVCWithEFCF9.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext dc = new SchoolDbContext();
        public ActionResult Index()
        {
            return View(dc.Students);
        }
    }
}