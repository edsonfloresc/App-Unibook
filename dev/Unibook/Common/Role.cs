//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Univalle.Fie.Sistemas.Unibook.Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.User = new HashSet<User>();
        }
    
        public short RoleId { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<User> User { get; set; }
    }
}