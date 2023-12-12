using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebApplicationNITExample.Models;

namespace WebApplicationNITExample.Controllers
{
    public class SampleController : Controller
    {
        public ViewResult Index(int? Id, string FirstName, string LastName)
        {
            //ViewData
            ViewData["id"] = Id;
            ViewData["firstname"] = FirstName;
            ViewData["lastname"] = LastName;
            string[] Coures = { "SSC", "Intermediate", "Degree", "PG" };
            ViewData["coures"] = Coures;
            List<string> ListCoures = new List<string>() { "SSC", "Intermediate", "Degree", "PG" };
            ViewData["listcoures"] = ListCoures;

            //ViewBag
            ViewBag.id = Id;
            ViewBag.firstname = FirstName;
            ViewBag.lastname = LastName;
            string[] ViewBagCoures = { "SSC", "Intermediate", "Degree", "PG" };
            ViewBag.coures = ViewBagCoures;
            List<string> ViewBagListCoures = new List<string>() { "SSC", "Intermediate", "Degree", "PG" };
            ViewBag.listcoures = ViewBagListCoures;

            //TempData
            TempData["id"] = Id;
            TempData["firstname"] = FirstName;
            TempData["lastname"] = LastName;
            string[] TempCoures = { "SSC", "Intermediate", "Degree", "PG" };
            TempData["coures"] = Coures;
            List<string> TempListCoures = new List<string>() { "SSC", "Intermediate", "Degree", "PG" };
            TempData["listcoures"] = ListCoures;

            return View();
        }
        public RedirectToRouteResult Index1(int? Id, string FirstName, string LastName)
        {
            TempData["id"] = Id;
            TempData["firstname"] = FirstName;
            TempData["lastname"] = LastName;
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult IndexCookies(int? Id, string FirstName, string LastName) 
        {
            HttpCookie cookie = new HttpCookie("ProductCookie");
            cookie["Id"] = Id.ToString();
            cookie["Name"] = FirstName;
            cookie["Price"] = LastName.ToString();
            Response.Cookies.Add(cookie);
            return View();
        }
        public RedirectToRouteResult IndexSession(int? Id, string FirstName, string LastName)
        {
            Session["Id"] = Id; 
            Session["FirstName"] = FirstName; 
            Session["LastName"] = LastName;
            return RedirectToAction("IndexSession2");
        }
        public ViewResult IndexSession2()
        {
            return View();
        }
        public ViewResult ModelIndex(Student student)
        {
            return View(student);
        }
    }
}