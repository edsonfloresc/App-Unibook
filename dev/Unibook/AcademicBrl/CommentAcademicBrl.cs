using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class CommentAcademicBrl
    {
        #region Methods

        /// <summary>
        /// Insert a comment
        /// </summary>
        /// <param name="commentAcademic">Object comment to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(CommentAcademicDto commentAcademicDto, ModelUnibookContainer objContex)
        {
            try
            {
                CommentAcademic commentAcademic = new CommentAcademic();
                commentAcademic.CommentAcademicId = commentAcademicDto.CommentAcademicId;
                commentAcademic.Description = commentAcademicDto.Description;
                commentAcademic.DateComment = commentAcademicDto.DateComment;
                commentAcademic.Deleted = commentAcademic.Deleted;
                commentAcademic.User = UserBrl.Get(commentAcademicDto.User.UserId,objContex);
                commentAcademic.PublicationAcademic = PublicationAcademicBrl.Get(commentAcademicDto.PublicationAcademic.PublicationAcademicId, objContex);
                CommentAcademicDal.Insert(commentAcademic, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get comment by id
        /// </summary>
        /// <param name="id">Id comment to search</param>
        /// <returns>Return object comment</returns>
        public static CommentAcademic Get(long id, ModelUnibookContainer objContex)
        {
            CommentAcademic commentAcademic = null;

            try
            {
                commentAcademic = CommentAcademicDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentAcademic;
        }

        /// <summary>
        /// Get comment by id dto
        /// </summary>
        /// <param name="id">Id comment to search</param>
        /// <returns>Return object comment</returns>
        public static CommentAcademicDto GetDto(long id, ModelUnibookContainer objContex)
        {
            CommentAcademicDto commentAcademicDto = null;

            try
            {
                CommentAcademic commentAcademic = CommentAcademicDal.Get(id,objContex);
                commentAcademicDto = new CommentAcademicDto();
                commentAcademicDto.Description = commentAcademic.Description;
                commentAcademicDto.DateComment = commentAcademic.DateComment;
                commentAcademicDto.Deleted = commentAcademic.Deleted;
                commentAcademicDto.User = UserBrl.GetDto(commentAcademic.User.UserId,objContex);                
                commentAcademicDto.PublicationAcademic = PublicationAcademicBrl.GetDto(commentAcademic.PublicationAcademic.PublicationAcademicId,objContex);             
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentAcademicDto;
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(CommentAcademicDto commentAcademicDto,ModelUnibookContainer objContex)
        {
            try
            {
                CommentAcademic commentAcademic = CommentAcademicDal.Get(commentAcademicDto.CommentAcademicId,objContex);
                commentAcademic.Description = commentAcademicDto.Description;
                commentAcademic.DateComment = commentAcademicDto.DateComment;
                commentAcademic.Deleted = commentAcademicDto.Deleted;
                commentAcademic.User = UserBrl.Get(commentAcademicDto.User.UserId,objContex);
                commentAcademic.PublicationAcademic = PublicationAcademicBrl.Get(commentAcademicDto.PublicationAcademic.PublicationAcademicId,objContex);
                CommentAcademicDal.Update(objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a comment
        /// </summary>
        /// <param name="id">Id comment to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentAcademicDal.Delete(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
