using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class CommentAcademicListDal
    {
        /// <summary>
        /// Get list comments
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<CommentAcademic> Get(ModelUnibookContainer objContex)
        {
            List<CommentAcademic> commentsReturn = null;

            try
            {
                commentsReturn = (from comment in objContex.CommentAcademicSet
                                    where comment.Deleted == false
                                    select comment).ToList<CommentAcademic>();
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

            return commentsReturn;
        }
    }
}
