using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCWithLinq1.Models
{
    public class StudentDAL
    {
        MVCDBDataContext context = new MVCDBDataContext(ConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString);
        public List<Student> GetStudents(bool? status) 
        {
            List<Student> students;
            try
            {
                if (status != null)
                    students = (from s in context.Students select s).ToList();
                else
                    students = (from s in context.Students where s.Status == status select s).ToList();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Student GetStudent(int id,bool? status)
        {
            Student student;
            try
            {
                if (status != null)
                    student = (from s in context.Students where s.Sid == id select s).Single();
                else
                    student = (from s in context.Students where s.Sid == id && s.Status == status select s).Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return student;
        }
        public void AddStudent(Student student)
        {
            try
            {
                context.Students.InsertOnSubmit(student);
                context.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateStudent(Student student)
        {
            try
            {
                Student s = context.Students.Single(S => S.Sid == student.Sid);
                s.Sid = student.Sid;
                s.Name = student.Name;
                s.Class = student.Class;
                s.Fees = student.Fees;
                s.Photo = student.Photo;
                s.Status = student.Status;
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteStudent(int id)
        {
            try
            {
                Student s = (from d in context.Students where d.Sid==id select d).FirstOrDefault();
                s.Status = false;
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}