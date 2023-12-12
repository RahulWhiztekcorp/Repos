using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotificationTosterDemo.Models;

namespace NotificationTosterDemo.Data
{
    public class NotificationTosterDemoContext : DbContext
    {
        public NotificationTosterDemoContext (DbContextOptions<NotificationTosterDemoContext> options)
            : base(options)
        {
        }

        public DbSet<NotificationTosterDemo.Models.EmployeeEntity> EmployeeEntity { get; set; }
    }
}
