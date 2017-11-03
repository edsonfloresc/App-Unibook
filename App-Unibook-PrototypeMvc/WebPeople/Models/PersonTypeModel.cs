using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.Unibook.Mvc.WebPeople.Models
{
    public class PersonTypeModel
    {
        public byte Id { get; set; }

        [Display(Name = "Type")]
        public string Name { get; set; }
    }
}
