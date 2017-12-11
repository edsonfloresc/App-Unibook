using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDto
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public bool Active { get; set; }
        public virtual LostObjectDto LostObject { get; set; }
    }
}
