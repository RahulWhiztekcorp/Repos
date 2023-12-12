﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithEFCF4.Models;
namespace MVCWithEFCF4.Controllers
{
    public class SchoolController : Controller
    {
        SchoolDbContext context = new SchoolDbContext();
        public ActionResult Index()
        {
            Student s1 = new Student
            {
                Name = "Rajesh",
                Phone = "23746666",
                Address = "Pune",
                Class = 10,
                Marks = 450.00f,
                Fees = 5000.00f
            };
            Student s2 = new Student
            {
                Name = "Ajay",
                Phone = "23747777",
                Address = "Mumbai",
                Class = 10,
                Marks = 450.00f,
                Fees = 5000.00f
            };
            Student s3 = new Student
            {
                Name = "Venkat",
                Phone = "23748888",
                Address = "Delhi",
                Class = 10,
                Marks = 450.00f,
                Fees = 5000.00f
            };
            Teacher t1 = new Teacher
            {
                Name = "Raju",
                Phone = "23741234",
                Address = "Delhi",
                Designation = "Lecturer",
                Salary = 25000.00,
                Subject = "Physics"
            };
            Teacher t2 = new Teacher
            {
                Name = "Suresh",
                Phone = "23745678",
                Address = "Delhi",
                Designation = "Lecturer",
                Salary = 25000.00,
                Subject = "Maths"
            };
            Teacher t3 = new Teacher
            {
                Name = "Rahul",
                Phone = "23747890",
                Address = "Delhi",
                Designation = "Lecturer",
                Salary = 25000.00,
                Subject = "Chemistry"
            };
            context.People.Add(s1); context.People.Add(s2); context.People.Add(s3);
            context.People.Add(t1); context.People.Add(t2); context.People.Add(t3);
            context.SaveChanges();
            return View();
        }
        public ViewResult DisplayPeople()
        {
            var p = from S in context.People select S;
            return View(p);
        }
        public ViewResult DisplayStudents()
        {
            var students = from s in context.People.OfType<Student>() select s;
            return View(students);
        }
        public ViewResult DispalyTeachers()
        {
            var t = from s in context.People.OfType<Teacher>() select s;
            return View(t);
        }
    }
}