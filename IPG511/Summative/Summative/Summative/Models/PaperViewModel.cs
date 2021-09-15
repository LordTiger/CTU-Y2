using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Summative.Models
{
    public class PaperViewModel
    {
        public IEnumerable<Paper> Papers { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
    }
}