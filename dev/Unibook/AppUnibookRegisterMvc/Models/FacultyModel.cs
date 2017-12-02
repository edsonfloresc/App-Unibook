using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models
{
    public class FacultyModel
    {
        public short FacultyId { get; set; }

        [Required(ErrorMessage = "RequiredName")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
