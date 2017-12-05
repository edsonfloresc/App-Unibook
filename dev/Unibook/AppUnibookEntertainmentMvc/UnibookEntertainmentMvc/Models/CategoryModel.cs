using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models
{
    public class CategoryModel
    {
        public Int16 CategoryId { get; set; }

        [Required(ErrorMessage = "RequiredFirstDescription")]
        [StringLength(200)]
        [Display(Description = "Description")]
        public string Description { get; set; }

        public bool Deleted { get; set; }
    }
}
