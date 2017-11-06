using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class SubjectCareerDto
    {
        public int SubjectCareerId { get; set; }

        public virtual CareerDto Career { get; set; }
        public virtual SubjectDto Subject { get; set; }
    }
}
