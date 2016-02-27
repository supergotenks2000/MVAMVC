using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        //public virtual ICollection<Product> Products { get; set; }

        private ICollection<Product> _products;

        public virtual ICollection<Product> Products
        {
            get { return _products ?? (_products = new Collection<Product>()); }
            set { _products = value; }
        }

        //public void AddProduct(Product product)
        //{
        //    product.Category = this;
        //    Products.Add(product);
        //}
    }
}
