using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models
{
    public class ImageModel
    {
        public long ImageId { get; set; }


        public string PathImage { get; set; }
        public bool Deleted { get; set; }
 

    
        public EntertainmentModel Entertainment { get; set; }



    }
}
