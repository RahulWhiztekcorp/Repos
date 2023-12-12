using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIListMVCAjaxCRUD.Models;

namespace WebAPIListMVCAjaxCRUD.Controllers
{
    public class ProductController : ApiController
    {
        public static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                ProductName = "Test",
                ProductPrice = 100,
            },
             new Product
            {
                Id = 2,
                ProductName = "Test2",
                ProductPrice = 200,
            }
        };
        public IEnumerable<Product> Get ()
        {
            return products;
        }
        public Product Get(int Id)
        {
            Product product = new Product();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == Id)
                {
                    product.Id = products[i].Id;
                    product.ProductName = products[i].ProductName;
                    product.ProductPrice = products[i].ProductPrice;
                }
            }
            return product;
        }
        public HttpResponseMessage Post(Product product)
        {
            if (product!=null)
            {
                products.Add(product);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public HttpResponseMessage Put(Product product) 
        {
            if (product!=null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id == product.Id)
                    {
                        products[i].Id = product.Id;
                        products[i].ProductName = product.ProductName;
                        products[i].ProductPrice = product.ProductPrice;
                    }
                }
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        public HttpResponseMessage Delete(int Id)
        {
            if (Id!=null)
            {
                //Index based
                //var index = Id - 1;
                //products.RemoveAt(index);

                //items based
                var item = products.Where(p => p.Id == Id).FirstOrDefault();
                products.Remove(item);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    }
}