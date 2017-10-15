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
    /// Descripción breve de WebCommentAcademicServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCommentAcademicServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(CommentAcademic commentAcademic)
        {
            try
            {
                CommentAcademicBrl.Insert(commentAcademic, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(CommentAcademic commentAcademic)
        {
            try
            {
                CommentAcademic commentAcademicUpdate = CommentAcademicBrl.Get(commentAcademic.CommentAcademicId, objContex);
                commentAcademicUpdate.Description = commentAcademic.Description;
                commentAcademicUpdate.DateComment = commentAcademic.DateComment;
                commentAcademicUpdate.Deleted = commentAcademic.Deleted;
                commentAcademicUpdate.User = commentAcademic.User;
                commentAcademic.PublicationAcademic = commentAcademic.PublicationAcademic;
                CommentAcademicBrl.Update(objContex);
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
                CommentAcademicBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public CommentAcademic Get(long id)
        {
            CommentAcademic commentAcademic = null;

            try
            {
                commentAcademic = CommentAcademicBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentAcademic;
        }
    }
}
