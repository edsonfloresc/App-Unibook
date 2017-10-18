using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.NewsDal
{
    public class NewDal
    {
        #region metodos

        /// <summary>
        /// Get News by id
        /// </summary>
        /// <param name="id">Id News to search</param>
        /// <returns></returns>
        public static News Get(int id, ModelUnibookContainer objContex)
        {
            News newsReturn = null;
            try
            {
                newsReturn = (from news in objContex.NewsSet
                              where news.Deleted == false && news.NewsId == id
                              select news).Single<News>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newsReturn;
        }

        /// <summary>
        /// Insert a News
        /// </summary>
        /// <param name="news"></param>
        /// <param name="objContex"></param>
        public static void Insert(News news, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.NewsSet.Add(news);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a News
        /// </summary>
        /// <param name="news"></param>
        /// <param name="objContex"></param>
        public static void Update(News news, ModelUnibookContainer objContex)
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
        /// Deleted a News
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                News news = objContex.NewsSet.Find(id);
                news.Deleted = true;
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
