using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppForumsMvc.Models
{
    public class CategoryModel
    {
        public short CategoryId { get; set; }

        [Required(ErrorMessage = "Required Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Purpose { get; set; }
    }
}
