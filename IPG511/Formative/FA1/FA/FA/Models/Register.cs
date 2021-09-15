//Brandon de Bruyn 6854
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace FA.Models
{
    public class Register
    {
        //ID
        [Key]
        [BindNever]
        public int id { get; set; }

        //Username
        [Required(ErrorMessage = "Username is Required")]
        [Display(Name = "Username:")]
        public string Username { get; set; }

        //Password
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }
    }
}