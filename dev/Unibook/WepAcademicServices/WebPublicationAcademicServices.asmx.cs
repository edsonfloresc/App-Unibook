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
        public void Insert(PublicationAcademic publicationAcademic)
        {
            try
            {
                PublicationAcademicBrl.Insert(publicationAcademic, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(PublicationAcademic publicationAcademic)
        {
            try
            {
                PublicationAcademic publicationAcademicUpdate = PublicationAcademicBrl.Get(publicationAcademic.PublicationAcademicId, objContex);
                publicationAcademicUpdate.Description = publicationAcademic.Description;
                publicationAcademicUpdate.Image = publicationAcademic.Image;
                publicationAcademicUpdate.DatePublication = publicationAcademic.DatePublication;
                publicationAcademicUpdate.Deleted = publicationAcademic.Deleted;
                publicationAcademicUpdate.CategoryAcademic = publicationAcademic.CategoryAcademic;
                publicationAcademicUpdate.User = publicationAcademic.User;
                PublicationAcademicBrl.Update(objContex);
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
        public PublicationAcademic Get(long id)
        {
            PublicationAcademic publicationAcademic = null;

            try
            {
                publicationAcademic = PublicationAcademicBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return publicationAcademic;
        }
    }
}
