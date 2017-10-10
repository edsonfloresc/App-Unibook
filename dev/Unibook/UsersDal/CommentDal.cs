using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.UsersDal
{      //florescedson@gmail.com
    public class CommentDal
    {

        #region metodos
        /// <summary>
        /// Method for Get CommentEnter like object
        /// </summary>
        /// <param name="id">id from CommentEnter Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a CommentEnter Object</returns>
        public static CommentEnter Get(int id, ModelUnibookContainer objContex)
        {
            CommentEnter commentReturn = null;


            try
            {
                commentReturn = (from comment in objContex.CommentEnterSet
                                 where comment.Deleted == false && comment.CommentId == id
                                 select comment).Single<CommentEnter>();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentReturn;
        }

        /// <summary>
        /// Method for insert a new CommentEnter 
        /// </summary>
        /// <param name="category"> object from class CommentEnter for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(CommentEnter comment, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CommentEnterSet.Add(comment);
                objContex.SaveChanges();
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
        /// Method for Update CommentEnter
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
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
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from CommentEnter for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentEnter comment = objContex.CommentEnterSet.Find(id);
                comment.Deleted = true;
                objContex.SaveChanges();
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
