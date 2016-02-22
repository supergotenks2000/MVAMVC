using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC.Models
{
    public class Person
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(10, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(10, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 16)]
        [DataType(DataType.CreditCard)]
        [Display(Name = "Credit Card")]
        public string CreditCard { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float Amount { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone #")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime Time { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        public string Upload { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string Url { get; set; }
    }
}
