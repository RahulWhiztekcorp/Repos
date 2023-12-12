﻿using MVCWithLinq2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithLinq2.Controllers
{
    public class StudentController : Controller
    {
           MVCDBDataContext context = new MVCDBDataContext(ConfigurationManager.ConnectionStrings["MVCDBConnectionString"].ConnectionString); //New Version
        public ViewResult DisplayStudents()
        {
            List<Student_SelectResult> students = context.Student_Select(null, true).ToList();
            return View(students);
        }
        public ViewResult DisplayStudent(int Sid)
        {
            Student_SelectResult student = context.Student_Select(Sid, true).ToList()[0];
            return View(student);
        }
        [HttpGet]
        public ViewResult AddStudent()
        {
            Student_SelectResult student = new Student_SelectResult();
            return View(student);
        }
        [HttpPost]
        public RedirectToRouteResult AddStudent(Student_SelectResult student, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string folderPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                selectedFile.SaveAs(folderPath + selectedFile.FileName);
                student.Photo = selectedFile.FileName;
            }
            context.Student_Insert(student.Sid, student.Name, student.Class, student.Fees, student.Photo);
            return RedirectToAction("DisplayStudents");
        }
        public ViewResult EditStudent(int Sid)
        {
            Student_SelectResult student = context.Student_Select(Sid, true).ToList()[0];
            TempData["Photo"] = student.Photo;
            return View(student);
        }
        public RedirectToRouteResult UpdateStudent(Student_SelectResult student, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string folderPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                selectedFile.SaveAs(folderPath + selectedFile.FileName);
                student.Photo = selectedFile.FileName;
            }
            else if (TempData["Photo"] != null)
            {
                student.Photo = TempData["Photo"].ToString();
            }
            context.Student_Update(student.Sid, student.Name, student.Class, student.Fees, student.Photo);
            return RedirectToAction("DisplayStudents");
        }
        public RedirectToRouteResult DeleteStudent(int Sid)
        {
            context.Student_Delete(Sid);
            return RedirectToAction("DisplayStudents");
        }

    }
}