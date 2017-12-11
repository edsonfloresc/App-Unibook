using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsDal;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl
{
    public class CommentBrl
    {
        #region metodos
        /// <summary>
        /// Method for Get CommentEnter like object
        /// </summary>
        /// <param name="id">id from CommentEnter Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a CommentEnter Object</returns>
        public static CommentEnterDto GetDto(int id, ModelUnibookContainer objContex)
        {

            CommentEnterDto commentDto = null;
            try
            {

                CommentEnter comment = CommentDal.Get(id, objContex);
                commentDto = new CommentEnterDto();
                commentDto.CommentId = comment.CommentId;
                commentDto.CommentText = comment.CommentText;
                commentDto.DateHour = comment.DateHour;
                commentDto.Deleted = comment.Deleted;
                commentDto.Entertainment = EntertainmentBrl.GetDto(comment.Entertainment.EntertainmentId, objContex); 
             
            }

            catch (Exception)
            {
                return null;
            }

            return commentDto;
        }
        /// <summary>
        /// Method for Get CommentEnter like object
        /// </summary>
        /// <param name="id">id from CommentEnter Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a CommentEnter Object</returns>
        public static CommentEnter Get(int id, ModelUnibookContainer objContex)
        {

            try
            {
                return CommentDal.Get(id, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }
        /// <summary>
        /// Method for insert a new CommentEnter 
        /// </summary>
        /// <param name="comment"> object from class CommentEnter for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(CommentEnterDto commentDto, ModelUnibookContainer objContex)
        {
            try
            {


                CommentEnter comment = new CommentEnter();
                comment.CommentText = commentDto.CommentText;
                comment.DateHour = commentDto.DateHour;
                comment.Deleted = commentDto.Deleted;
                comment.Entertainment = EntertainmentBrl.Get(int.Parse(commentDto.Entertainment.EntertainmentId.ToString()), objContex);
                comment.User = UserBrl.Get(int.Parse(comment.User.UserId.ToString()), objContex);
                CommentDal.Insert(comment, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Method for Update CommentEnter
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(CommentEnterDto commentDto, ModelUnibookContainer objContex)
        {
            try
            {

                CommentEnter comment = CommentBrl.Get(int.Parse(commentDto.CommentId.ToString()), objContex);
                comment.CommentText = commentDto.CommentText;
                comment.DateHour = commentDto.DateHour;
                comment.Deleted = commentDto.Deleted;
                comment.Entertainment = EntertainmentBrl.Get(int.Parse(commentDto.Entertainment.EntertainmentId.ToString()), objContex);
                comment.User = UserBrl.Get(int.Parse(comment.User.UserId.ToString()), objContex);
                CommentDal.Update(objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from CommentEnter for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentDal.Delete(id, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
