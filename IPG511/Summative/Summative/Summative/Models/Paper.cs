using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Summative.Models
{
    public class Paper
    {
        [Key]
        [BindNever]
        public int PaperId { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Desc Required")]
        public string Desc { get; set; }

        [Required(ErrorMessage = "Abstract Required")]
        public string Abstract { get; set; }

        public DateTime SubmissionDate { get; set; }

        public string AuthorName { get; set; }

        [BindNever]
        public int TopicId { get; set; }
        public string sTopicId { get; set; }
    }
}