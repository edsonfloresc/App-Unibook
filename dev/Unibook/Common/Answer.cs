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
    
    public partial class Answer
    {
        public long AnswerId { get; set; }
        public string Content { get; set; }
        public short Points { get; set; }
        public bool Solved { get; set; }
        public bool Deleted { get; set; }
    
        public virtual Questions Questions { get; set; }
        public virtual User User { get; set; }
    }
}
