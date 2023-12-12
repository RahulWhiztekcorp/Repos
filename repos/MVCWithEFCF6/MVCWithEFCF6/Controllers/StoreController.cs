using MVCWithEFCF6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF6.Controllers
{
    public class StoreController : Controller
    {
        StoreDbContext dc = new StoreDbContext();
        public ActionResult Index()
        {
            Customer c1 = new Customer { CustomerId = 101, CustomerName = "Raju" };
            Customer c2 = new Customer { CustomerId = 102, CustomerName = "Ajay" };
            Customer c3 = new Customer { CustomerId = 103, CustomerName = "Suresh" };

            Product p1 = new Product { ProductId = 1001, ProductName = "Soap" };
            Product p2 = new Product { ProductId = 1002, ProductName = "Perfume" };
            Product p3 = new Product { ProductId = 1003, ProductName = "Pen" };

            dc.Customers.Add(c1); dc.Customers.Add(c2); dc.Customers.Add(c3);
            dc.Products.Add(p1); dc.Products.Add(p2); dc.Products.Add(p3);

            dc.SaveChanges();
            return View();
        }

    }
}