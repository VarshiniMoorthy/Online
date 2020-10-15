using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingSystem.Models
{
    public class LoginView
    {
        
        [Required]
        [Key]
        [Range(typeof(string), "U", "Z", ErrorMessage = "not valid")]
        public string EmailId { set; get; }
        [Required]
        public string Password { set; get; }
    }
}