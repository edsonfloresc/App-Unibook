using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.NewsDal
{
    public class CommentNewDal
    {
        #region metodos

        /// <summary>
        /// Get CommentNews by id
        /// </summary>
        /// <param name="id">Id CommentNews to search</param>
        /// <returns></returns>
        public static CommentNews Get(int id, ModelUnibookContainer objContex)
        {
            CommentNews commentnewsReturn = null;
            try
            {
                commentnewsReturn = (from commentnews in objContex.CommentNewsSet
                                     where commentnews.Deleted == false && commentnews.CommentId == id
                                     select commentnews).Single<CommentNews>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentnewsReturn;
        }

        /// <summary>
        /// Insert a CommentNews
        /// </summary>
        /// <param name="CommentNews"></param>
        /// <param name="objContex"></param>
        public static void Insert(CommentNews commentnews, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CommentNewsSet.Add(commentnews);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a CommentNews
        /// </summary>
        /// <param name="CommentNews"></param>
        /// <param name="objContex"></param>
        public static void Update(CommentNews commentnews, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a CommentNews
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentNews commentnews = objContex.CommentNewsSet.Find(id);
                commentnews.Deleted = true;
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion metodos
    }
}
