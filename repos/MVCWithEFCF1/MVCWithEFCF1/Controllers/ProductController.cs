using MVCWithEFCF1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF1.Controllers
{
    public class ProductController : Controller
    {
        StoreDbContext db = new StoreDbContext();
        public ViewResult DisplayProducts()
        {
            var data = db.Products.Include(s=>s.Category);
            return View(data);  
        }
        public ViewResult DisplayProduct(int Id)
        {
            return View(db.Products.Where(s=>s.Id == Id).Include(s => s.Category).Single());
        }
        public ViewResult AddProduct() 
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddProduct(Product product,HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string DirectoryPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(DirectoryPath))
                {
                    Directory.CreateDirectory(DirectoryPath);
                }
                selectedFile.SaveAs(DirectoryPath + selectedFile.FileName);
                BinaryReader br = new BinaryReader(selectedFile.InputStream);
                product.ProductImage = br.ReadBytes(selectedFile.ContentLength);
                product.ProductImageName = selectedFile.FileName;
            }
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("DisplayProducts");
        }
        public ViewResult EditProduct(int Id)
        {
            Product product = db.Products.Find(Id);
            TempData["ProductImage"] = product.ProductImage;
            TempData["ProductImageName"] = product.ProductImageName;
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);  
        }
        [HttpPost]
        public RedirectToRouteResult EditProduct(Product product, HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null)
            {
                string DirectoryPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(DirectoryPath))
                {
                    Directory.CreateDirectory(DirectoryPath);
                }
                selectedFile.SaveAs(DirectoryPath + selectedFile.FileName);
                BinaryReader br = new BinaryReader(selectedFile.InputStream);
                product.ProductImage = br.ReadBytes(selectedFile.ContentLength);
                product.ProductImageName = selectedFile.FileName;
            }
            else if (TempData["ProductImage"] != null && TempData["ProductImageName"] != null)
            {
                product.ProductImage = (byte[])TempData["ProductImage"];
                product.ProductImageName = (string)TempData["ProductImageName"];
            }
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("DisplayProducts");
        }
        public RedirectToRouteResult DeleteProduct(int Id)
        {
            Product product = db.Products.Where(s=>s.Id== Id).FirstOrDefault();
            product.Discontinued = true;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("DisplayProducts");

        }
    }
}