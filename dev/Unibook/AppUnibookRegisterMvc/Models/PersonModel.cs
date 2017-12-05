using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models
{
    public class PersonModel
    {
        public long PersonId { get; set; }

        [Required(ErrorMessage = "RequiredName")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "RequiredLastName")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        public DateTime? BirthDay { get; set; }

        public GenderModel Gender { get; set; }
        public bool Deleted { get; set; }

        public UserModel User { get; set; }
    }
}
