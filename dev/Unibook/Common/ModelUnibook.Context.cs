﻿//------------------------------------------------------------------------------
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
    
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<UserCareer> UserCareer { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Password> Password { get; set; }
    }
}
