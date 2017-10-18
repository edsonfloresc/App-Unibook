using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsDal
{
    public class CommentListDal
    {
        #region metodo
        /// <summary>
        /// Method for make a list from all table
        /// </summary>
        /// <param name="objContex"></param>
        /// <returns>list from table CommentEnter</returns>
        public static List<CommentEnter> Get(ModelUnibookContainer objContex)
        {
            List<CommentEnter> commentReturn = null;


            try
            {
                commentReturn = (from comment in objContex.CommentEnter
                                 where comment.Deleted == false
                                 select comment).ToList<CommentEnter>();
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

            return commentReturn;

        }
        #endregion
    }
}
