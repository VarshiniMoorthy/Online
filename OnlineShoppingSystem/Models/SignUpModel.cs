using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class SignUpModel
    {
       

        [Required(ErrorMessage = "Email Required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter a valid email address")]
        //[RegularExpression(" ^[a - zA - Z0 - 9_\\.-] +@([a - zA - Z0 - 9 -] +\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not Valid EmailId")]

        public string EmailId { get; set; }
        [RegularExpression("^.{4,8}$", ErrorMessage = " Matches any string between 4 and 8 characters in length. Limits the length of a string")]
        [Required(ErrorMessage = "Password Required")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Retype the same password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Provide Gender")]
        public string Gender { get; set; }

        [Range(10, 120, ErrorMessage = "Age Should be min 10 and max 120")]
        [Required(ErrorMessage = "Please provide Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
        //[Required(ErrorMessage = "Please provide LanguageKnown")]
       // [Range(typeof(bool), "true", "true", ErrorMessage = " language known required")]

        //public string LanguageKnown { get; set; }

        [Required(ErrorMessage = "Please provide Address")]

        public string Address { get; set; }
        [RegularExpression("^\\d{6,}$",ErrorMessage ="Invalid Pincode")]
        [Required(ErrorMessage = "Please provide Pincode")]
        public int Pincode { get; set; }


    }
}