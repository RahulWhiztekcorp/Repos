//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWithEFDBF2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public Nullable<int> Class { get; set; }
        public Nullable<decimal> Fees { get; set; }
        public string Photo { get; set; }
        public bool Status { get; set; }
    }
}
