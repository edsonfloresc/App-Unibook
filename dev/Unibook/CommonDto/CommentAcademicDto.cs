using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class CommentAcademicDto
    {
        public long CommentAcademicId { get; set; }
        public string Description { get; set; }
        public System.DateTime DateComment { get; set; }
        public bool Deleted { get; set; }

        public virtual UserDto User { get; set; }
        public virtual PublicationAcademicDto PublicationAcademic { get; set; }
    }
}
