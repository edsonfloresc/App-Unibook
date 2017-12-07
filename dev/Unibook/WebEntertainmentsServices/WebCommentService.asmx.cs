using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WebEntertainmentsServices
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
        public void Insert(CommentEnterDto comment)
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
        public void Update(CommentEnterDto comment)
        {
            try
            {
                CommentEnterDto comment1 = CommentBrl.GetDto(int.Parse(comment.CommentId.ToString()), content);
                comment1.CommentText = comment.CommentText;

                CommentBrl.Update(comment1, content);
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
        public CommentEnterDto Get(int id)
        {
            CommentEnterDto comment = null;
            try
            {
                comment = CommentBrl.GetDto(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return comment;

        }

    }
}
