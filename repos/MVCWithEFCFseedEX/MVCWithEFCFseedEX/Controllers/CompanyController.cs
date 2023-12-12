using MVCWithEFCFseedEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCFseedEX.Controllers
{
    public class CompanyController: Controller
    {
        CompanyDbContext dc = new CompanyDbContext();
        public ViewResult Index()
        {
            return View(dc.Employees);
        }
    }
}