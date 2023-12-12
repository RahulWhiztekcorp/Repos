using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiService.Models;
using System.Security.Cryptography;

namespace WebApiService.Controllers
{
    public class StudentController : ApiController
    {
        MVCDBEntities dc = new MVCDBEntities();
        public List<Student> Get()
        {
            return dc.Students.ToList();
        }
        public Student Get(int id)
        {
            Student sss=null;
            List<Student> students = dc.Students.ToList();
            int count = dc.Students.Count();
            for (int i = 0; i < count; i++)
            {
                var oid = students[i].Id;
                if (oid == id)
                {
                    sss = students[i];
                    break;
                }
            }
            return sss;
        }
        public HttpResponseMessage Post(Student student)
        {
            try
            {
                student.Status = true;
                dc.Students.Add(student);
                dc.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
        public HttpResponseMessage Put(Student student)
        {
            try
            {
                Student data = dc.Students.Find(student.Id);
                if (data == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
                data.Id = student.Id;
                data.Name = student.Name;
                data.Photo = student.Photo;
                data.Status = student.Status;
                dc.Entry(data).State = EntityState.Modified;
                dc.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                Student obj = dc.Students.Find(id);
                if (obj == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
                obj.Status = false;
                dc.Entry(obj).State = EntityState.Modified;
                dc.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }

        }
    }
}