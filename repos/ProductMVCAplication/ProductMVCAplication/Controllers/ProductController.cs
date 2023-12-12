using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ProductMVCAplication.Models;
using System.Collections.Generic;

namespace ProductMVCAplication.Controllers
{
    public class ProductController : Controller
    {
        // read
        public static List<Product> products = new List<Product>();
        public IActionResult Index()
        {
            string[] list = { "Grocery", "Footwear", "Electronics", "Furniture", "Jewellery" };
            ViewBag.li = list;
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                Product newpdata = new Product
                {
                    PId = p.PId,
                    ProductName = p.ProductName,
                    ProductPrice = p.ProductPrice,
                    ProtductType = p.ProtductType,
                    IsDelete = false,
                };
                products.Add(newpdata);
                return RedirectToAction("Index", products);
            }
            else
            {
                return View("Create");
            }
        }
        public Product GetProductDetailsById(int ID)
        {
            Product product = new Product();
            for (int i = 0; i < products.Count; i++)
            {
                if (ID == products[i].PId)
                {
                    product.PId = products[i].PId;
                    product.ProductName = products[i].ProductName;
                    product.ProductPrice = products[i].ProductPrice;
                    product.ProtductType = products[i].ProtductType;
                    product.IsDelete = products[i].IsDelete;
                }
            }
            return product;
        }
        [HttpGet]
        public IActionResult GetProductByID(int ID)
        {
            var data = GetProductDetailsById(ID);
            return View(data);
        }
        [HttpGet]
        public IActionResult Update(int ID)
        {
            var data = GetProductDetailsById(ID);
            return View(data);
        }
        [HttpPost]
        public IActionResult Update(Product p)
        {
            if (ModelState.IsValid)
            {
                if (p.IsDelete == null)
                    p.IsDelete = false;
                else
                    p.IsDelete=p.IsDelete;
                //updateing the data
                products[products.FindIndex(a => a.PId == p.PId)] = p;
                return RedirectToAction("Index", products);
            }
            else
            {
                return View("Create");
            }
        }
        [HttpGet]
        public IActionResult Delete(int ID)
        {
            var data = GetProductDetailsById(ID);
            Product newpdata = new Product
            {
                PId = data.PId,
                ProductName = data.ProductName,
                ProductPrice = data.ProductPrice,
                ProtductType = data.ProtductType,
                IsDelete = true,
            };
            products[products.FindIndex(a => a.PId == data.PId)] = newpdata;
            return RedirectToAction("Index", products);
        }

        public IActionResult GetproductsByCategory(string category)
        {
            return RedirectToAction("Index", products.FirstOrDefault(s => s.ProtductType == category));
        }
        //[HttpPost]
        //public IActionResult Delete(Product p)
        //{
        //    if (p!=null)
        //    {
        //        Product newpdata = new Product
        //        {
        //            PId = p.PId,
        //            ProductName = p.ProductName,
        //            ProductPrice = p.ProductPrice,
        //            ProtductType = p.ProtductType,
        //            IsDelete = true,
        //        };
        //        products[products.FindIndex(a => a.PId == p.PId)] = newpdata;
        //        return RedirectToAction("Index", products);
        //    }
        //    else
        //    {
        //        return View("Index");
        //    }
        //}

    }
}
