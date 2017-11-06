using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class PublicationAcademicDto
    {    
        public long PublicationAcademicId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public System.DateTime DatePublication { get; set; }
        public bool Deleted { get; set; }
        
        public virtual CategoryAcademicDto CategoryAcademic { get; set; }
        public virtual UserDto User { get; set; }
    }
}
