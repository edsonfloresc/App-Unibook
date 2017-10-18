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
        public void InsertCommentNew(CommentNews commentnew)
        {
            try
            {
                CommentNewBrl.Insertar(commentnew, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void UpdateCommentNew(CommentNews commentnew)
        {
            try
            {
                CommentNewBrl.Update(commentnew, dbcontext);
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
                CommentNewBrl.Delete(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public CommentNews GetCommentNew(int id)
        {
            CommentNews commentnew = null;
            try
            {
                commentnew = CommentNewBrl.Get(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentnew;

        }
    }
}
