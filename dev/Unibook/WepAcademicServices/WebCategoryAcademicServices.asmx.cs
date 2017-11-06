using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WepAcademicServices
{
    /// <summary>
    /// Descripción breve de WebCategoryAcademicServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCategoryAcademicServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(CategoryAcademicDto categoryAcademicDto)
        {
            try
            {
                CategoryAcademicBrl.Insert(categoryAcademicDto, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(CategoryAcademicDto categoryAcademicDto)
        {
            try
            {
                CategoryAcademicBrl.Update(categoryAcademicDto,objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Delete(int id)
        {
            try
            {
                CategoryAcademicBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public CategoryAcademicDto Get(int id)
        {
            CategoryAcademicDto categoryAcademicDto = null;

            try
            {
                categoryAcademicDto = CategoryAcademicBrl.GetDto(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryAcademicDto;
        }
    }
}
