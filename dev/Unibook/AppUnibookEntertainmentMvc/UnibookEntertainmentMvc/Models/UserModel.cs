using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models
{
    public class UserModel
    {

        public long UserId { get; set; }

        [Required(ErrorMessage = "RequiredName")]
        [Display(Name = "Name")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RequiredPassword")]
        [Display(Name = "Password")]
        public PasswordModel Password { get; set; }

        public bool Deleted { get; set; }

        [Display(Name = "Role")]
        public RoleModel Role { get; set; }

        [Display(Name = "Person")]
        public PersonModel Person { get; set; }
    }
}
