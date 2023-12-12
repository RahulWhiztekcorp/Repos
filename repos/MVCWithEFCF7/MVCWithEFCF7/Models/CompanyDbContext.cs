using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF7.Models
{
    public class CompanyDbContext:DbContext 
    {
        public CompanyDbContext() : base("ConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CompanyDbContext>());
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}