using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCFseedEX.Models
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext() : base("ConStr")
        {
            Database.SetInitializer(new CompanyDBInitializer());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}