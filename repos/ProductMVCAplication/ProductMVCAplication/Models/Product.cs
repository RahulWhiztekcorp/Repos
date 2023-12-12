using System.ComponentModel.DataAnnotations;

namespace ProductMVCAplication.Models
{
    public class Product
    {
        [Required (ErrorMessage ="Please enter this Product Id")]
        public int? PId { get; set; }
        [Required(ErrorMessage = "Please enter this Product Name")]
        public string? ProductName { get; set; }
        [Required (ErrorMessage ="Please enter this Product Price")]
        public Decimal? ProductPrice { get; set; }
        [Required (ErrorMessage ="Please enter this Product Type")]
        public string? ProtductType { get; set; }
        public bool? IsDelete { get; set; }
    }
}
