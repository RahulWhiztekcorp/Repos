using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWithEFCF1.Models
{
    public class Test
    {
        [Key]
        public int INT { get; set; }
        public long LONG { get; set; }
        public float FLOAT { get; set; }
        public double DOUBLE { get; set; }
        public char CHAR { get; set; }
        public string STRING { get; set; }
        public bool BOOL { get; set; }
        public byte BYTE { get; set; }

    }
}