using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class CommentAcademicDal
    {
        #region Methods

        /// <summary>
        /// Get comment by id
        /// </summary>
        /// <param name="id">Id comment to search</param>
        /// <returns>Return object comment</returns>
        public static CommentAcademic Get(long id, ModelUnibookContainer objContex)
        {
            CommentAcademic commentAcademicReturn = null;

            try
            {

                bool exist = (from commentAcademic in objContex.CommentAcademicSet
                              where commentAcademic.Deleted == false && commentAcademic.CommentAcademicId == id
                              select commentAcademic).Count() > 0;
                if (exist)
                {
                    commentAcademicReturn = (from commentAcademic in objContex.CommentAcademicSet
                                             where commentAcademic.Deleted == false && commentAcademic.CommentAcademicId == id
                                             select commentAcademic).Single<CommentAcademic>();
                }
               
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return commentAcademicReturn;
        }

        /// <summary>
        /// Insert a comment
        /// </summary>
        /// <param name="commentAcademic">Object comment to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(CommentAcademic commentAcademic, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CommentAcademicSet.Add(commentAcademic);
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                CommentAcademic commentAcademic = objContex.CommentAcademicSet.Find(id);
                commentAcademic.Deleted = true;
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        #endregion 
    }
}
