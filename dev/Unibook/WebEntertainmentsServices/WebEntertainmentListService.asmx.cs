using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WebEntertainmentsServices
{
    /// <summary>
    /// Descripción breve de WebEntertainmentListService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebEntertainmentListService : System.Web.Services.WebService
    {

        ModelUnibookContainer content = new ModelUnibookContainer();
        [WebMethod]
        public List<EntertainmentDto> Get()
        {
            List<EntertainmentDto> entertainmentList = new List<EntertainmentDto>();

            try
            {
                entertainmentList = EntertainmentListBrl.Get(content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entertainmentList;
        }
    }
}
