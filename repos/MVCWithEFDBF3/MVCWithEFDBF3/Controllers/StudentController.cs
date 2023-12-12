using MVCWithEFDBF3.Models;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFDBF3.Controllers
{
    public class StudentController : Controller
    {
        MVCDBEntities context = new MVCDBEntities();
        public ViewResult DisplayStudents()
        {
            return View(context.Student_Select(null, true));
        }
        public ViewResult DisplayStudent(int Sid)
        {
            return View(context.Student_Select(Sid, true).Single());
        }   
        public ViewResult AddStudent()
        {
            Student_Select_Result student = new Student_Select_Result();
            return View(student);
        }
        [HttpPost]
        public RedirectToRouteResult AddStudent(Student_Select_Result student, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string PhysicalPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(PhysicalPath))
                    Directory.CreateDirectory(PhysicalPath);
                selectedFile.SaveAs(PhysicalPath + selectedFile.FileName);
                student.Photo = selectedFile.FileName;
            }
            context.Student_Insert(student.Sid, student.Name, student.Class, student.Fees, student.Photo);
            return RedirectToAction("DisplayStudents");
        }
        public ViewResult EditStudent(int sid)
        {
            var student = context.Student_Select(sid, true).Single();
            TempData["Photo"] = student.Photo;
            return View(student);
        }
        public RedirectToRouteResult UpdateStudent(Student_Select_Result student, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string PhysicalPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(PhysicalPath))
                    Directory.CreateDirectory(PhysicalPath);
                selectedFile.SaveAs(PhysicalPath + selectedFile.FileName);
                student.Photo = selectedFile.FileName;
            }
            else if (TempData["Photo"] != null)
            {
                student.Photo = TempData["Photo"].ToString();
            }
            context.Student_Update(student.Sid, student.Name, student.Class, student.Fees, student.Photo);
            return RedirectToAction("DisplayStudents");
        }

        public ViewResult DeleteStudent(int sid)
        {
            return View(context.Student_Select(sid, true).Single());
        }
        [HttpPost]
        public RedirectToRouteResult DeleteStudent(Student_Select_Result student)
        {
            context.Student_Delete(student.Sid);
            return RedirectToAction("DisplayStudents");
        }
    }
}