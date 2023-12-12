using MVCWithEFCF5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWithEFCF5
{
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public Spouse Spouse { get; set; }
    }
}