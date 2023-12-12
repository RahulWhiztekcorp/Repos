using MVCWithEFCF7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF7.Controllers
{
    public class CompanyController : Controller
    {
        CompanyDbContext dc = new CompanyDbContext();
        public ActionResult Index()
        {
            Department d1 = new Department { Did = 10, Dname = "Sales", Location = "Hyderabad" };
            Department d2 = new Department { Did = 20, Dname = "Research", Location = "Delhi" };
            Department d3 = new Department { Did = 30, Dname = "HR", Location = "Mumbai" };
            Department d4 = new Department { Did = 40, Dname = "Finance", Location = "Chennai" };
            dc.Departments.Add(d1);
            dc.Departments.Add(d2);
            dc.Departments.Add(d3);
            dc.Departments.Add(d4);

            Employee e1 = new Employee { Ename = "Raju", Job = "Manager", Salary = 25000.00, Did = 10 };
            Employee e2 = new Employee { Ename = "John", Job = "Clerk", Salary = 10000.00, Did = 10 };
            Employee e3 = new Employee { Ename = "Pankaj", Job = "Manager", Salary = 25000.00, Did = 20 };
            Employee e4 = new Employee { Ename = "Suneel", Job = "Manager", Salary = 25000.00, Did = 30 };
            dc.Employees.Add(e1);
            dc.Employees.Add(e2);
            dc.Employees.Add(e3);
            dc.Employees.Add(e4);
            dc.SaveChanges();
            return View(dc.Employees);
        }

    }
}