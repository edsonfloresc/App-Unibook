using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models
{
    public class RoleModel
    {

        [Required(ErrorMessage = "Id Requerido")]
        [Display(Name = "Id")]
        public short RoleId { get; set; }

        [Required(ErrorMessage = "Name Requerido")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public bool Deleted { get; set; }
    }
}
