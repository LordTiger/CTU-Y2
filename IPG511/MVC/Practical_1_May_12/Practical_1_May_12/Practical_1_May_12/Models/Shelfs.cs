using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Practical_1_May_12.Models
{
    public class Shelfs
    {

        [Key]
        [BindNever]
        public int id { set; get; }

        [Display(Name = "Shelf Name")]
        public char ShelfName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}