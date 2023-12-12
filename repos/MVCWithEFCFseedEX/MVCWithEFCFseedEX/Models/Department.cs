using MVCWithEFCFseedEX.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithEFCFseedEX.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Did { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}