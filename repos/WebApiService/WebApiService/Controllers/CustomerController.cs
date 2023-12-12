using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiService.Models;
using System.Web.Http.Cors;

namespace WebApiService.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        MVCDBEntities dc;
        public CustomerController()
        {
            dc = new MVCDBEntities();
        }
        public List<Customer> Get()
        {
            return dc.Customers.ToList();
        }
        public Customer Get(int id)
        {
            return dc.Customers.Where(p => p.Custid == id).FirstOrDefault();
        }
        public HttpResponseMessage Post(Customer customer)
        {
            try
            {
                customer.Status = true;
                dc.Customers.Add(customer);
                dc.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
        public HttpResponseMessage Put(Customer customer)
        {
            try
            {
                Customer data = dc.Customers.Find(customer.Custid);
                if (data == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
                data.Custid = customer.Custid;
                data.Name = customer.Name;
                data.Balance = customer.Balance;
                data.City = customer.City;
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
                Customer obj = dc.Customers.Find(id);
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