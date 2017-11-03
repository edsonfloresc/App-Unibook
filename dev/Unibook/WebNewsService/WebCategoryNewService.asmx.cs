using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;
using Univalle.Fie.Sistemas.Unibook.CommonDto;

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
        public void InsertCategoryNew(CategoryNewsDto categorynewdto)
        {
            try
            {
                CategoryNewBrl.Insertar(categorynewdto, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void UpdateCategoryNew(CategoryNewsDto categorynewsdto)
        {
            try
            {
                CategoryNewBrl.Update(categorynewsdto, dbcontext);
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
        public CategoryNewsDto GetCategoryNew(int id)
        {
            CategoryNewsDto categorynewsdto = null;
            try
            {
                categorynewsdto = CategoryNewBrl.GetDto(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categorynewsdto;

        }
    }
}
