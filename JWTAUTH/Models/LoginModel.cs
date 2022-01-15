using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username Is Required")]
        public string Username { set; get; }

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { set; get; }
    }
}
