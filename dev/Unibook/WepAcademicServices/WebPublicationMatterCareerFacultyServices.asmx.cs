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
    /// Descripción breve de WebPublicationMatterCareerFacultyServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPublicationMatterCareerFacultyServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto)
        {
            try
            {
                PublicationMatterCareerFacultyBrl.Insert(publicationMatterCareerFacultyDto, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto)
        {
            try
            {              
                PublicationMatterCareerFacultyBrl.Update(publicationMatterCareerFacultyDto,objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        [WebMethod]
        public PublicationMatterCareerFacultyDto Get(int id)
        {
            PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto = null;

            try
            {
                publicationMatterCareerFacultyDto = PublicationMatterCareerFacultyBrl.GetDto(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationMatterCareerFacultyDto;
        }
    }
}
