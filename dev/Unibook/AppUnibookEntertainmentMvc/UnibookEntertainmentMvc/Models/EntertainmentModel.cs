using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models
{
    public class EntertainmentModel
    {

        public Int64 EntertainmentId { get; set; }

        [Required(ErrorMessage = "RequiredTitle")]
        [StringLength(200)]
        [Display(Name  = "Title")]
        public string Title { get; set; }


        [Required(ErrorMessage = "RequiredPlaceAddress")]
        [StringLength(200)]
        [Display(Name = "PlaceAddress")]
        public string PlaceAddress { get; set; }


       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy HH:mm}")]
        
        public DateTime DateHour { get; set; }


        [Required(ErrorMessage = "RequiredDetails")]
        [StringLength(200)]
        [Display(Name = "Details")]
        public string Details { get; set; }
        public bool Deleted { get; set; }
        public bool Discontinued { get; set; }

        [Display(Name = "CategoryEnter")]
        public CategoryModel Category { get; set; }

        [Display(Name = "User")]
        public UserModel User { get; set; }





    }
}
