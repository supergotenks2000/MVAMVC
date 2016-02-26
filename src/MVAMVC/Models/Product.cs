using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public decimal MSRP { get; set; }
        public decimal CurrentPrice { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
