using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.WebAppLogin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email required.")]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required.")]
        [StringLength(50)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
