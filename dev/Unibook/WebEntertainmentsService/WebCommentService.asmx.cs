using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using UsersBrl;

namespace WebEntertainmentsService
{
    /// <summary>
    /// Descripción breve de WebCommentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCommentService : System.Web.Services.WebService
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(CommentEnter comment)
        {
            try
            {
                CommentBrl.Insert(comment, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(CommentEnter comment)
        {
            try
            {
                CommentEnter comment1 = CommentBrl.Get(int.Parse(comment.CommentId.ToString()), content);
                comment1.CommentText = comment.CommentText;

                CommentBrl.Update(content);
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
                CommentBrl.Delete(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public CommentEnter Get(int id)
        {
            CommentEnter comment = null;
            try
            {
                comment = CommentBrl.Get(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return comment;

        }

    }
}
