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
    /// Descripción breve de WebSubjectListServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebSubjectListServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public List<SubjectDto> Get()
        {
            try
            {
                return SubjectListBrl.Get(objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
