using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC.Models
{
    public class Category
    {
        [Required]
        [Display(Name="Category ID")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name="Display Name")]
        public string DisplayName { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        public virtual List<Product> Products { get; set; }
    }
}
