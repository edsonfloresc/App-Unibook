using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class CommentEnterDto
    {
        public long CommentId { get; set; }
        public string CommentText { get; set; }
        public System.DateTime DateHour { get; set; }
        public bool Deleted { get; set; }

        public virtual EntertainmentDto Entertainment { get; set; }
        public virtual UserDto User { get; set; }
    }
}
