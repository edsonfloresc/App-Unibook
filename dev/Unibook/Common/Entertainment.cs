
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
    
public partial class Entertainment
{

    public Entertainment()
    {

        this.CommentEnter = new HashSet<CommentEnter>();

        this.ImageEnter = new HashSet<ImageEnter>();

    }


    public long EntertainmentId { get; set; }

    public string Title { get; set; }

    public string PlaceAddress { get; set; }

    public System.DateTime DateHour { get; set; }

    public string Details { get; set; }

    public bool Deleted { get; set; }

    public bool Discontinued { get; set; }



    public virtual CategoryEnter CategoryEnter { get; set; }

    public virtual ICollection<CommentEnter> CommentEnter { get; set; }

    public virtual ICollection<ImageEnter> ImageEnter { get; set; }

    public virtual User User { get; set; }

}

}
