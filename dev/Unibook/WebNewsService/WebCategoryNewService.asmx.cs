using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

namespace Univalle.Fie.Sistemas.Unibook.WebNewsService
{
    /// <summary>
    /// Descripción breve de WebCategoryNewService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCategoryNewService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontext = new ModelUnibookContainer();
        [WebMethod]
        public void InsertCategoryNew(CategoryNews categorynew)
        {
            try
            {
                CategoryNewBrl.Insertar(categorynew, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void UpdateCategoryNew(CategoryNews categorynews)
        {
            try
            {
                CategoryNewBrl.Update(categorynews, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void DeleteCategoryNew(int id)
        {
            try
            {
                CategoryNewBrl.Delete(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public CategoryNews GetCategoryNew(int id)
        {
            CategoryNews categorynews = null;
            try
            {
                categorynews = CategoryNewBrl.Get(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categorynews;

        }
    }
}
