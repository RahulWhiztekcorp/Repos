using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NotificationTosterDemo.Data;
using NotificationTosterDemo.Models;

namespace NotificationTosterDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<EmployeeEntity> employeeEntities = new List<EmployeeEntity>() { new EmployeeEntity { Id = 1, Email = "Rahul", Name = "Rahul" } };

        // GET: EmployeeEntities
        public IActionResult Index()
        {
            TempData["message"] = "Employee Succesfully Fetched";
            return View( employeeEntities.ToList());
        }

        // GET: EmployeeEntities/Details/5
        public  IActionResult Details(int? id)
        {

            var employeeEntity = employeeEntities.Where(e => e.Id == id).FirstOrDefault();
            if (employeeEntity == null)
            {
                return NotFound();
            }

            return View(employeeEntity);
        }

        // GET: EmployeeEntities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Name,Email")] EmployeeEntity employeeEntity)
        {
            if (ModelState.IsValid)
            {
                employeeEntities.Add(employeeEntity);
                TempData["message"] = "Employee Succesfully Created";
                return RedirectToAction(nameof(Index));
            }
            return View(employeeEntity);
        }
    }
}
