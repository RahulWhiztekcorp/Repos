using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace WebApplicationNITExample.Controllers
{
    public class EmpController : Controller
    {
        //16-06-2023 start
        //Html Controls Example
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        //type 1
        //[HttpPost]
        //public ViewResult AddEmp(int Id,string Name,string Job,double? Salary) 
        //{
        //    //write code for saveing the data
        //    ViewData["Id"] = Id;
        //    ViewData["Name"] = Name;
        //    ViewData["Job"] =   Job;
        //    ViewData["Salary"] = Salary;
        //    return View("DisplayEmp");
        //}
        //type 2
        [HttpPost]
        public ViewResult AddEmp(FormCollection fc)
        {   
            ViewData["Id"] = fc["Id"];
            ViewData["Name"] = fc["Name"];
            ViewData["Job"] = fc["Job"];
            ViewData["Salary"] = fc["Salary"];
            return View("DisplayEmp");
        }
        //end
    }
}