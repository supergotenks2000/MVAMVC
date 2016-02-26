using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC.Models
{
    public class Product
    {
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal? MSRP { get; set; }
        
        [DataType(DataType.Currency)]
        [Display(Name = "Current Price")]
        public decimal? CurrentPrice { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
