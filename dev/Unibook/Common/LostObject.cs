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
    
    public partial class LostObject
    {
        public LostObject()
        {
            this.Comment = new HashSet<Comment>();
        }
    
        public int LostObjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public System.DateTime LostDate { get; set; }
        public string DisplayTime { get; set; }
    
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual Category Category { get; set; }
        public virtual State State { get; set; }
        public virtual Person Person { get; set; }
    }
}
