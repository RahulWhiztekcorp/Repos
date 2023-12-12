using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class Student
    {
        public Guid Sid = new Guid();
        public string Name { get; set; }
        public int Class { get; set; }
        public string Gender { get; set; }
        public double Fees { get; set; }
        public string Address { get; set; }

    }
}