using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WepAcademicServices
{
    /// <summary>
    /// Descripción breve de WebPublicationAcademicServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPublicationAcademicServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(PublicationAcademicDto publicationAcademicDto)
        {
            try
            {
                PublicationAcademicBrl.Insert(publicationAcademicDto, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(PublicationAcademicDto publicationAcademicDto)
        {
            try
            {              
                PublicationAcademicBrl.Update(publicationAcademicDto,objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Delete(long id)
        {
            try
            {
                PublicationAcademicBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public PublicationAcademicDto Get(long id)
        {
            PublicationAcademicDto publicationAcademicDto = null;

            try
            {
                publicationAcademicDto = PublicationAcademicBrl.GetDto(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationAcademicDto;
        }
    }
}
