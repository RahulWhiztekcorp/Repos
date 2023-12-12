using Ecommerce.Asp.NETWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ecommerce.Asp.NETWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            new Product { Id = 4, Name = "Bhagavathgetha", Category = "Books", Price = 10M },
            new Product { Id = 5, Name = "IPhone 14", Category = "Mobile", Price = 14.99M }
        };
        //https://localhost:44347/api/products
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        //https://localhost:44347/api/products/{id}
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}