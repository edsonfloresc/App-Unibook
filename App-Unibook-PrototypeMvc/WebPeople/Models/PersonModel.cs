using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.Unibook.Mvc.WebPeople.Models
{
    public class PersonModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public bool Deleted { get; set; }

        public PersonTypeModel PersonType { get; set; }
    }
}
