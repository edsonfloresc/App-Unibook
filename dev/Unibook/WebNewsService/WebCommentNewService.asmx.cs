using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.CommonDto;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

namespace Univalle.Fie.Sistemas.Unibook.WebNewsService
{
    /// <summary>
    /// Descripción breve de WebCommentNewService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCommentNewService : System.Web.Services.WebService
    {
        ModelUnibookContainer dbcontext = new ModelUnibookContainer();
        [WebMethod]
        public void InsertCommentNew(CategoryNewsDto categorynewdto)
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
        public void UpdateCommentNew(CategoryNewsDto categorynewsdto)
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
        public void DeleteCommentNew(int id)
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
        public CategoryNewsDto GetCommentNew(int id)
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
