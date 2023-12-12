namespace MVCWithEFCF9.Migrations
{
    using MVCWithEFCF9.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCWithEFCF9.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCWithEFCF9.Models.SchoolDbContext context)
        {
            Student s = new Student()
            {
                StudentId = 01,
                Name = "rahul",
                Class = 11,
                Section = "English"
            };
            context.Students.Add(s);
            context.SaveChanges();

        }
    }
}
