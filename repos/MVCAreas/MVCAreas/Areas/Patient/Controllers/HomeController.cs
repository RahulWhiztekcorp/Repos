﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAreas.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Patient/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}