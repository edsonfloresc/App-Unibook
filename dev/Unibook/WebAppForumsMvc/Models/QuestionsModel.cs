using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppForumsMvc.Models
{
    public class QuestionsModel
    {
        public long QuestionsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public short Points { get; set; }
        public bool Solved { get; set; }
        public bool Deleted { get; set; }
    }
}
