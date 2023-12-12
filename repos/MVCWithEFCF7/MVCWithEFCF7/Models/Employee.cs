using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWithEFCF7.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public int Did { get; set; }
        [ForeignKey("Did")]
        public Department Department { get; set; }

    }
}