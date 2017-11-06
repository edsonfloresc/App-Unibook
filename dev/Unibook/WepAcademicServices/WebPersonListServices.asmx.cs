using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WepAcademicServices
{
    /// <summary>
    /// Descripción breve de WebPersonListServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonListServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public List<PersonDto> Get()
        {
            try
            {
                return PersonListBrl.Get(objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
