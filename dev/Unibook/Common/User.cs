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
    
    public partial class User
    {
        public User()
        {
            this.UserCareer = new HashSet<UserCareer>();
        }
    
        public long UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public short GenderId { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public short RoleId { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<UserCareer> UserCareer { get; set; }
        public virtual Role Role { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
