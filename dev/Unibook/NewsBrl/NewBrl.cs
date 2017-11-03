using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.NewsDal;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;
namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class NewBrl
    {
        /// <summary>
        /// Create a new News
        /// </summary>
        /// <param name="News"></param>
        /// <param name="objContex"></param>
        public static void Insertar(NewsDto newsdto, ModelUnibookContainer objContex)
        {
            try
            {
                News news = new News();
                news.Title = newsdto.Title;
                news.Detail = newsdto.Detail;
                news.PublicationNews = newsdto.PublicationNews;
                news.DateNews = newsdto.DateNews;
                news.Discontinued = newsdto.Discontinued;
                news.Deleted = newsdto.Deleted;
                news.CategoryNews = CategoryNewBrl.Get(newsdto.CategoryNews.CategoryId, objContex);
                news.User = UserBrl.Get(newsdto.User.UserId, objContex);
                NewDal.Insert(news, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a News with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static NewsDto GetDto(int id, ModelUnibookContainer objContex)
        {
            NewsDto newsdto = null;
            try
            {
                News news = NewDal.Get(id, objContex);
                newsdto = new NewsDto();
                newsdto.Title = news.Title;
                newsdto.Detail = news.Detail;
                newsdto.DateNews = news.DateNews;
                newsdto.PublicationNews = news.PublicationNews;
                newsdto.Discontinued = news.Discontinued;
                newsdto.Deleted = news.Deleted;
                newsdto.CategoryNews = CategoryNewBrl.GetDto(news.CategoryNews.CategoryId, objContex);
                newsdto.User = UserBrl.GetDto(news.User.UserId, objContex);


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newsdto;
        }

        /// <summary>
        /// Get a News with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static News Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return NewDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="News"></param>
        /// <param name="objContex"></param>
        public static void Update(NewsDto newsdto, ModelUnibookContainer objContex)
        {
            try
            {
                News news = NewDal.Get(newsdto.NewsId, objContex);
                news.Title = newsdto.Title;
                news.Detail = newsdto.Detail;
                news.DateNews = newsdto.DateNews;
                news.PublicationNews = newsdto.PublicationNews;
                news.Discontinued = newsdto.Discontinued;
                news.Deleted = newsdto.Deleted;
                news.CategoryNews = CategoryNewBrl.Get(newsdto.CategoryNews.CategoryId, objContex);
                news.User = UserBrl.Get(newsdto.User.UserId, objContex);
                NewDal.Update(news, objContex);

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
                NewDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
