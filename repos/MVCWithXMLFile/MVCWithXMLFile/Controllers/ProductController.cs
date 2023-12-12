using MVCWithXMLFile.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithXMLFile.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            string xmlData = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Test.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var products = new List<Product>();
            products = (from rows in ds.Tables[0].AsEnumerable()
                        select new Product
                        {
                            to = rows[0].ToString(), //Convert row to int  
                            heading = rows[2].ToString(),
                            body = rows[3].ToString(),
                        }).ToList();
            return View(products);
        }
    }
}