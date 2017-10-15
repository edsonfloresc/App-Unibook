using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;

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
        public static void Insert(CommentAcademic commentAcademic, ModelUnibookContainer objContex)
        {
            try
            {
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
        /// Update a comment
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
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
