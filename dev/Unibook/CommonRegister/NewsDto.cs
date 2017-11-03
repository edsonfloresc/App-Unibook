using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class NewsDto
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public System.DateTime DateNews { get; set; }
        public System.DateTime PublicationNews { get; set; }
        public bool Discontinued { get; set; }
        public bool Deleted { get; set; }

        public virtual CategoryNewsDto CategoryNews { get; set; }

        public virtual UserDto User { get; set; }
    }
}
