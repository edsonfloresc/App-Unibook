using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
namespace Univalle.Fie.Sistemas.UniBook.NewsDal
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
                newsReturn = (from news in objContex.News
                              where news.Deleted == false && news.NewsId == id
                              select news).Single<News>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                objContex.News.Add(news);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                News news = objContex.News.Find(id);
                news.Deleted = true;
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        #endregion metodos
    }
}
