using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class QuestionsDto
    {
        public long QuestionsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public short Points { get; set; }
        public bool Solved { get; set; }
        public bool Deleted { get; set; }

        public virtual CategoryDto Category { get; set; }
        public virtual AnswerDto Answer { get; set; }
        public virtual UserDto User { get; set; }
    }
}
