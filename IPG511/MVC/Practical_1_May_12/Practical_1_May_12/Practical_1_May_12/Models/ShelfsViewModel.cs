using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_1_May_12.Models
{
    public class ShelfsViewModel
    {
        public IEnumerable<Shelfs> Shelfs { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}