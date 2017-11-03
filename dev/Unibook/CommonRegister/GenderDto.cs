using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class GenderDto
    {
        public short GenderId { get; set; }
        public string Name { get; set; }
        public PersonDto Person { get; set; }
    }
}
