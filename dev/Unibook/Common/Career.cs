
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
    
public partial class Career
{

    public Career()
    {

        this.UserCareer = new HashSet<UserCareer>();

    }


    public int CareerId { get; set; }

    public string Name { get; set; }

    public bool Deleted { get; set; }



    public virtual Faculty Faculty { get; set; }

    public virtual ICollection<UserCareer> UserCareer { get; set; }

}

}
