﻿using MVCWithEFDBF2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFDBF2.Controllers
{
    public class EmployeeController : Controller
    {
        MVCDBEntities dc = new MVCDBEntities();
        public ViewResult DisplayEmployees()
        {
            dc.Configuration.LazyLoadingEnabled = false;
            var Emps = dc.Employees.Where(E => E.Status == true).Include(E => E.Department);
            return View(Emps);

        }
        public ViewResult DisplayEmployee(int Eid)
        {
            dc.Configuration.LazyLoadingEnabled = false;
            var Emp = (dc.Employees.Where(E => E.Eid == Eid).Include(E => E.Department)).Single();
            return View(Emp);

        }
        public ViewResult AddEmployee()
        {
            ViewBag.Did = new SelectList(dc.Departments, "Did", "Dname");
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddEmployee(Employee Emp)
        {
            Emp.Status = true;
            dc.Employees.Add(Emp);
            dc.SaveChanges();
            return RedirectToAction("DisplayEmployees");
        }
        public ViewResult EditEmployee(int Eid)
        {
            Employee Emp = dc.Employees.Find(Eid);
            ViewBag.Did = new SelectList(dc.Departments, "Did", "Dname", Emp.Did);
            return View(Emp);
        }
        public RedirectToRouteResult UpdateEmployee(Employee Emp)
        {
            Emp.Status = true;
            dc.Entry(Emp).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayEmployees");
        }
        public ViewResult DeleteEmployee(int Eid)
        {
            Employee Emp = dc.Employees.Find(Eid);
            return View(Emp);
        }
        [HttpPost]
        public RedirectToRouteResult DeleteEmployee(Employee Emp)
        {
            //If we want to update the status of employee use the below code:
            dc.Entry(Emp).State = EntityState.Modified;
            //If we want to delete the record permanently comment the above statement and un-comment the below:
            //dc.Entry(Emp).State = EntityState.Deleted;    
            dc.SaveChanges();
            return RedirectToAction("DisplayEmployees");
        }

    }
}