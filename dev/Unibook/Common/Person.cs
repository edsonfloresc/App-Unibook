//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Univalle.Fie.Sistemas.Unibook.Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Contact = new HashSet<Contact>();
        }
    
        public long PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual User User { get; set; }
    }
}
