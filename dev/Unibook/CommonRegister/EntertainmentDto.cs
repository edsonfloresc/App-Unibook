using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class EntertainmentDto
    {
        public long EntertainmentId { get; set; }
        public string Title { get; set; }
        public string PlaceAddress { get; set; }
        public System.DateTime DateHour { get; set; }
        public string Details { get; set; }
        public bool Deleted { get; set; }
        public bool Discontinued { get; set; }

        public virtual CategoryEnterDto CategoryEnter { get; set; }
        public virtual UserDto Users { get; set; }
    }
}
