using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class CategoryDto
    {
        public short CategoryId { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public virtual QuestionsDto Questions { get; set; }
    }
}
