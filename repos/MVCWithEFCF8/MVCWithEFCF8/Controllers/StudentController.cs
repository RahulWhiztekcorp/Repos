using MVCWithEFCF8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF8.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext dc = new SchoolDbContext();
        public ActionResult Index()
        {
            Student s = new Student { Name = "Raju" };
            dc.Students.Add(s);
            dc.SaveChanges();
            return View();
        }

    }
}