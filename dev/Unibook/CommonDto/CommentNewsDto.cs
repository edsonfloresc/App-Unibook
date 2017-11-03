using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
namespace Univalle.Fie.Sistemas.Unibook.CommonDto
{
    public class CommentNewsDto
    {
        public int CommentId { get; set; }
        public string Message { get; set; }
        public System.DateTime Date { get; set; }
        public bool Deleted { get; set; }

        public virtual User User { get; set; }
        public virtual News News { get; set; }
    }
}
