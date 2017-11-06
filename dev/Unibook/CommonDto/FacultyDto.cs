using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class FacultyDto
    {
        public short FacultyId { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public CareerDto Career { get; set; }
    }
}
