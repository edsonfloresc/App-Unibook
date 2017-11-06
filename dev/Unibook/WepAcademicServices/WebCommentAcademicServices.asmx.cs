using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.WepAcademicServices
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
        public void Insert(CommentAcademicDto commentAcademicDto)
        {
            try
            {
                CommentAcademicBrl.Insert(commentAcademicDto, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(CommentAcademicDto commentAcademicDto)
        {
            try
            {
                CommentAcademic commentAcademicUpdate = CommentAcademicBrl.Get(commentAcademicDto.CommentAcademicId, objContex);
                commentAcademicUpdate.Description = commentAcademicDto.Description;
                commentAcademicUpdate.DateComment = commentAcademicDto.DateComment;
                commentAcademicUpdate.Deleted = commentAcademicDto.Deleted;
                commentAcademicUpdate.User = UserBrl.Get((commentAcademicDto.User.UserId),objContex);
                commentAcademicUpdate.PublicationAcademic = PublicationAcademicBrl.Get(commentAcademicDto.PublicationAcademic.PublicationAcademicId,objContex);
                CommentAcademicBrl.Update(commentAcademicDto,objContex);
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
        public CommentAcademicDto Get(long id)
        {
            CommentAcademicDto commentAcademicDto = null;

            try
            {
                commentAcademicDto = CommentAcademicBrl.GetDto(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentAcademicDto;
        }
    }
}
