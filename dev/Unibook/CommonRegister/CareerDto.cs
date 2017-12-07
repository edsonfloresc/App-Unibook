using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class CareerDto
    {
        public int CareerId { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public FacultyDto Faculty { get; set; }
        public UserCareerDto UserCareer { get; set; }
    }
}
