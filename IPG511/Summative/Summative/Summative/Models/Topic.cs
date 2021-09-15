using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Summative.Models
{
    public class Topic
    {
        [Key]
        [BindNever]
        public int TopicId { get; set; }
        public string TopicName { get; set; }
    }
}