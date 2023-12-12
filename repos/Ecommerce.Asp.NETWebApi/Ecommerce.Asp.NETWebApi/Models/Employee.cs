using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Asp.NETWebApi.Models
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int EAge { get; set; }
        public long EMobileNumber { get; set; }
        public string EAddress { get; set; }
    }
}