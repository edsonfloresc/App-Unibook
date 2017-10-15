using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace WepAcademicServices
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
        public void Insert(PublicationMatterCareerFaculty publicationMatterCareerFaculty)
        {
            try
            {
                PublicationMatterCareerFacultyBrl.Insert(publicationMatterCareerFaculty, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(PublicationMatterCareerFaculty publicationMatterCareerFaculty)
        {
            try
            {
                PublicationMatterCareerFaculty publicationMatterCareerFacultyUpdate = PublicationMatterCareerFacultyBrl.Get(publicationMatterCareerFaculty.PublicationMatterCareerFacultyId, objContex);
                publicationMatterCareerFacultyUpdate.PublicationAcademic = publicationMatterCareerFaculty.PublicationAcademic;
                publicationMatterCareerFacultyUpdate.Subject = publicationMatterCareerFaculty.Subject;
                publicationMatterCareerFacultyUpdate.Career = publicationMatterCareerFaculty.Career;
                publicationMatterCareerFacultyUpdate.Faculty = publicationMatterCareerFaculty.Faculty;
                PublicationMatterCareerFacultyBrl.Update(objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        [WebMethod]
        public PublicationMatterCareerFaculty Get(int id)
        {
            PublicationMatterCareerFaculty publicationMatterCareerFaculty = null;

            try
            {
                publicationMatterCareerFaculty = PublicationMatterCareerFacultyBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationMatterCareerFaculty;
        }
    }
}
