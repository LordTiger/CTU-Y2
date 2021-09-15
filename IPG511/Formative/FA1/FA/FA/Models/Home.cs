//Brandon de Bruyn 6854
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace FA.Models
{
    public class Home
    {
        //ID
        [Key]
        [BindNever]
        public int id { get; set; }

        //First Name
        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        //Last Name
        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        //Address 1
        [Required(ErrorMessage = "Address 1 is Required")]
        [Display(Name = "Address 1: ")]
        public string Address1 { get; set; }

        //Address 2
        [Display(Name = "Address 2: ")]
        public string Address2 { get; set; }

        //Email ID
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "EmailID: ")]
        public string EmailID { get; set; }
    }
}