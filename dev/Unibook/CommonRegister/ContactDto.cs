﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.CommonDto
{
    public class ContactDto
    {
        public System.Guid ContactId { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public PersonDto Person { get; set; }
    }
}
