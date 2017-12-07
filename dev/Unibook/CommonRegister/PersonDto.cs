﻿using System;
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
        public System.DateTime Birthday { get; set; }
        public ContactDto Contact { get; set; }
        public GenderDto Gender { get; set; }
        public UserDto User { get; set; }
    }
}
