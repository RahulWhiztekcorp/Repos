using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWithEFCF2.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        //using System.ComponentModel.DataAnnotations;
        [Key]
        //using System.ComponentModel.DataAnnotations.Schema;
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sid { get; set; }
        [MaxLength(100)]
        [Column("Sname",TypeName="Varchar")]
        public string SupplierName { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}