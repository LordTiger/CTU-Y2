using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Practical_1_May_12.Models
{
    public class Product
    {
        //ID
        [Key]
        [BindNever]
        public int id { get; set; }

        //Name
        [Required(ErrorMessage = "Product Name is Required!")]
        [StringLength(32, ErrorMessage = "Max Lenght allowd is 32, Minimum Length is 5", MinimumLength = 5)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        //Description
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Price
        [Required(ErrorMessage = "Price Required!")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public int ShelfId { get; set; }
    }
}