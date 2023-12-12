using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF8.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext() : base("ConStr")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDbContext, Migrations.Configuration>());
        }
        public DbSet<Student> Students { get; set; }
    }
}