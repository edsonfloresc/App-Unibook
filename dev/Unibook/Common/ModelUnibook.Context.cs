﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelUnibookContainer : DbContext
    {
        public ModelUnibookContainer()
            : base("name=ModelUnibookContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<UserCareer> UserCareer { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
    }
}
