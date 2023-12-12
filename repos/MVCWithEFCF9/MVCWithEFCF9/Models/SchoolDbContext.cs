using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF9.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("ConStr")
        {
        }
        public DbSet<Student> Students { get; set; }
    }

}