using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class PersonDto
    {       
        public long PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public bool Deleted { get; set; }

        public virtual GenderDto Gender { get; set; }       
        public virtual UserDto User { get; set; }
    }
}
