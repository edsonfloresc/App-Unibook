using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models
{
    public class PasswordModel
    {
        public long PasswordId { get; set; }

        [Required(ErrorMessage = "RequiredPassword")]
        [Display(Name = "Password")]
        public string Psw { get; set; }
        public DateTime Date { get; set; }
        public byte State { get; set; }
        public string NewPassword { get; set; }
        public long UserId { get; set; }
    }
}
