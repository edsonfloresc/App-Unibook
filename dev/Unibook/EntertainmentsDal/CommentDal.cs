using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsDal
{
    public class CommentDal
    {
        #region metodos

        /// <summary>
        /// Method for get a CommentEnter like object
        /// </summary>
        /// <param name="id">id from CommentEnter</param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CommentEnter Get(int id, ModelUnibookContainer objContex)
        {
            CommentEnter CommentReturn = null;


            try
            {
                CommentReturn = (from comment in objContex.CommentEnter
                                 where comment.Deleted == false && comment.CommentId == id
                                 select comment).Single<CommentEnter>();
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

            return CommentReturn;
        }

        /// <summary>
        /// Method for insert a CommentEnter
        /// </summary>
        /// <param name="image">object for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(CommentEnter comment, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CommentEnter.Add(comment);
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
        /// Method for update a CommentEnter object in database 
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
        /// Method for deleted in presentation but put true en deleted CommentEnter
        /// </summary>
        /// <param name="id">id from CommentEnter object</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentEnter comment = objContex.CommentEnter.Find(id);
                comment.Deleted = true;
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
