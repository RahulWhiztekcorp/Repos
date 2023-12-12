using MVCWithLinq1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithLinq1.Controllers
{
    public class StudentController : Controller
    {
        StudentDAL studentDAL = new StudentDAL();
        public ViewResult DisplayStudents()
        {
            List<Student> students = studentDAL.GetStudents(true); 
            return View(students);
        }
        public ViewResult DisplayStudent(int Sid)
        {
            Student students = studentDAL.GetStudent(Sid, true);
            return View(students);
        }
        public ViewResult AddStudent()
        {
            return View();  
        }
        [HttpPost]
        public RedirectToRouteResult AddStudent(Student student, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string PhysicalPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(PhysicalPath))
                {
                    Directory.CreateDirectory(PhysicalPath);
                }
                selectedFile.SaveAs(PhysicalPath + selectedFile.FileName);
                student.Photo = selectedFile.FileName;
            }
            student.Status = true;
            studentDAL.AddStudent(student);
            return RedirectToAction("DisplayStudents");
        }
        public ViewResult EditStudent(int Sid) 
        {
            Student student = studentDAL.GetStudent(Sid, true);
            TempData["Photo"] = student.Photo;
            return View(student);
        }
        [HttpPost]
        public RedirectToRouteResult EditStudent(Student student, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string PhysicalPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(PhysicalPath))
                {
                    Directory.CreateDirectory(PhysicalPath);
                }
                selectedFile.SaveAs(PhysicalPath + selectedFile.FileName);
                student.Photo = selectedFile.FileName;
            }
            else if (TempData["Photo"] != null)
            {
                student.Photo = TempData["Photo"].ToString();
            }
            studentDAL.UpdateStudent(student);
            return RedirectToAction("DisplayStudents");
        }
        public RedirectToRouteResult DeleteStudent(int Sid)
        {
            studentDAL.DeleteStudent(Sid);
            return RedirectToAction("DisplayStudents");
        }
    }
}