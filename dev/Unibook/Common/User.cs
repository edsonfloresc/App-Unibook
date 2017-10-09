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
    
    public partial class User
    {
        public User()
        {
            this.UserCareer = new HashSet<UserCareer>();
            this.News = new HashSet<News>();
            this.CommentNews = new HashSet<CommentNews>();
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
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<CommentNews> CommentNews { get; set; }
    }
}
