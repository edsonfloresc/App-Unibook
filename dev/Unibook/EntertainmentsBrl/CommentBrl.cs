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

           //     CommentEnter comment = CommentDal.Get(id, objContex);
           //     commentDto = new CommentEnterDto();
           //     commentDto.CommentId = comment.CommentId;
           //     commentDto.CommentText = comment.CommentText;
           //     commentDto.DateHour = comment.DateHour;
           //     commentDto.Deleted = comment.Deleted;
           //     commentDto.Entertainment = new EntertainmentDto();
           //     commentDto.Entertainment.EntertainmentId = comment.Entertainment.EntertainmentId;
           //     commentDto.Entertainment.Title = comment.Entertainment.Title;
           //     commentDto.Entertainment.PlaceAddress = comment.Entertainment.PlaceAddress;
           //     commentDto.Entertainment.DateHour = comment.Entertainment.DateHour;
           //     commentDto.Entertainment.Details = comment.Entertainment.Details;
           //     commentDto.Entertainment.Deleted = comment.Entertainment.Deleted;
           //     commentDto.Entertainment.Discontinued = comment.Entertainment.Discontinued;
           //     commentDto.Entertainment.User = new UserDto();
           //     commentDto.Entertainment.User.UserId = comment.Entertainment.User.UserId;
           //     commentDto.Entertainment.User.Email = comment.Entertainment.User.Email;
           //     commentDto.Entertainment.User.Password = comment.Entertainment.User.Password;
           //     commentDto.Entertainment.User.Deleted = comment.Entertainment.User.Deleted;
           ////     commentDto.Entertainment.User.RoleId = comment.Entertainment.User.RoleId;
           //     commentDto.Entertainment.CategoryEnter = new CategoryEnterDto();
           //     commentDto.Entertainment.CategoryEnter.CategoryId = comment.Entertainment.CategoryEnter.CategoryId;
           //     commentDto.Entertainment.CategoryEnter.Description = comment.Entertainment.CategoryEnter.Description;
           //     commentDto.Entertainment.CategoryEnter.Deleted = comment.Entertainment.CategoryEnter.Deleted;
           //     commentDto.User = new UserDto();
           //     commentDto.User.UserId = comment.User.UserId;
           //     commentDto.User.Email = comment.User.Email;
           //     commentDto.User.Password = comment.User.Password;
           //     commentDto.User.Deleted = comment.User.Deleted;
           //    // commentDto.User.RoleId = comment.User.RoleId;


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
