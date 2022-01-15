using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Username Is Required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email Is Required")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { set; get; }
    }
}
