﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF1.Models
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StoreDbContext>());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set;}
    }
}