using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public virtual PersonModel Person { get; set; }
    }
}
