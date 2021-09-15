using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Example1.Models.ViewModel
{
    public class Student
    {
        [Key]
        [BindNever]
        public int id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [Display(Name = "Fullname")]
        public string Fullname { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [StringLength(20, ErrorMessage = "Value should be less then 20 and at least 5 characters", MinimumLength = 5)]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}