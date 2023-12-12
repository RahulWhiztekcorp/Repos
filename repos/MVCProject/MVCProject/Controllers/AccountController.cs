using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Validate()
        {
            string Name = Request["txtName"];
            string Password = Request["txtPwd"];
            if (Name == "Admin" && Password == "Admin@123")
            {
                Session["Name"] = Name;
                return View("Success");
            }
            else
            {
                ViewBag.Name = Name;
                return View("Failure");
            }
        }

    }
}