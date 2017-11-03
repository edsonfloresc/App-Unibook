using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.NewsDal;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class ImageNewBrl
    {
        /// <summary>
        /// Create a new ImageNews
        /// </summary>
        /// <param name="ImageNews"></param>
        /// <param name="objContex"></param>
        public static void Insertar(ImageNewsDto imagenewsdto, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNews imagenews = new ImageNews();
                imagenews.PathImage = imagenewsdto.PathImage;
                imagenews.Deleted = imagenewsdto.Deleted;
                imagenews.News = NewBrl.Get(imagenewsdto.News.NewsId, objContex);
                ImageNewDal.Insert(imagenews, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a ImageNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static ImageNewsDto GetDto(int id, ModelUnibookContainer objContex)
        {
            ImageNewsDto imagenewsdto = null;
            try
            {
                ImageNews imagenews = ImageNewDal.Get(id, objContex);
                imagenewsdto = new ImageNewsDto();
                imagenewsdto.PathImage = imagenews.PathImage;
                imagenewsdto.Deleted = imagenews.Deleted;
                imagenewsdto.News = NewBrl.GetDto(imagenews.News.NewsId,objContex);
                imagenews.News = NewBrl.Get(imagenewsdto.News.NewsId, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return imagenewsdto;
        }

        /// Get a ImageNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static ImageNews Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return ImageNewDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="ImageNews"></param>
        /// <param name="objContex"></param>
        public static void Update(ImageNewsDto imagenewsdto, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNews imagenews = ImageNewDal.Get(imagenewsdto.ImageId, objContex);
                imagenews.PathImage = imagenewsdto.PathImage;
                imagenews.Deleted = imagenewsdto.Deleted;
                imagenews.News = NewBrl.Get(imagenewsdto.News.NewsId, objContex);
                ImageNewDal.Update(imagenews, objContex);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        /// <summary>
        /// Deleted a ImageNews
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNewDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
