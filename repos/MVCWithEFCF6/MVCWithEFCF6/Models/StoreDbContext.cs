using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF6.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base("ConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<StoreDbContext>());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }    
    }
}