using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class ImageEnterDto
    {

        public long ImageId { get; set; }
        public string PathImage { get; set; }
        public bool Deleted { get; set; }

        public virtual EntertainmentDto Entertainment { get; set; }
    }
}
