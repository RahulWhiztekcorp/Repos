using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithEFCF1.Models;

namespace MVCWithEFCF1.Controllers
{
    public class CategoryController : Controller
    {
        StoreDbContext dbContext = new StoreDbContext();
        public ActionResult DisplayCategories()
        {
            return View(dbContext.Categories.ToList());
        }
        public ViewResult DisplayCategory(int CategoryId)
        {
            return View(dbContext.Categories.Where(s=>s.CategoryId== CategoryId).Single());
        }
        public ViewResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return RedirectToAction("DisplayCategories");
        }
        public ViewResult EditCategory(int CategoryId)
        {
            return View(dbContext.Categories.Find(CategoryId));
        }
        [HttpPost]
        public RedirectToRouteResult UpdateCategory(Category category)
        {
            dbContext.Entry(category).State= EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction("DisplayCategories");
        }
        public RedirectToRouteResult DeleteCategory(int CategoryId)
        {
            Category category = dbContext.Categories.Find(CategoryId);
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
            return RedirectToAction("DisplayCategories");
        }

    }
}