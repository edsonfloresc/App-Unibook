using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class PersonDto
    {
        public System.Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Deleted { get; set; }

        public PersonTypeDto PersonType { get; set; }
    }
}
