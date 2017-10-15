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
    /// Descripción breve de WebCategoryAcademicService
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
        public void Insert(CategoryAcademic categoryAcademic)
        {
            try
            {
                CategoryAcademicBrl.Insert(categoryAcademic, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(CategoryAcademic categoryAcademic)
        {
            try
            {
                CategoryAcademic categoryAcademicUpdate = CategoryAcademicBrl.Get(categoryAcademic.CategoryAcademicId, objContex);
                categoryAcademicUpdate.Name = categoryAcademic.Name;
                categoryAcademicUpdate.Description = categoryAcademic.Description;
                categoryAcademicUpdate.Deleted = categoryAcademic.Deleted;
                CategoryAcademicBrl.Update(objContex);
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
                CategoryAcademicBrl.Delete(id,objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public CategoryAcademic Get(int id)
        {
            CategoryAcademic categoryAcademic = null;

            try
            {
                categoryAcademic = CategoryAcademicBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryAcademic;
        }
    }
}
