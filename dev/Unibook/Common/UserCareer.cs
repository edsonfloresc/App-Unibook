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
    
    public partial class UserCareer
    {
        public long UserCareerId { get; set; }
    
        public virtual User User { get; set; }
        public virtual Career Career { get; set; }
    }
}
