using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models
{
    public class CommentModel
    {
        public long CommentId { get; set; }

        [Required(ErrorMessage = "RequiredComment")]
        [StringLength(500)]
        [Display(Name = "CommentText")]
        public string CommentText { get; set; }


        public DateTime DateHour { get; set; }

        
        [Display(Name = "Deleted")]
   
        public bool Deleted { get; set; }
    

        [Display(Name = "Entertainment")]
        public EntertainmentModel Entertainment { get; set; }

        [Display(Name = "User")]
        public AppUnibookRegisterMvc.Models.UserModel User { get; set; }




    }
}
