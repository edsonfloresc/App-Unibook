using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
namespace Univalle.Fie.Sistemas.UniBook.NewsDal
{
    public class ImageNewDal
    {
        #region metodos

        /// <summary>
        /// Get ImageNews by id
        /// </summary>
        /// <param name="id">Id ImageNews to search</param>
        /// <returns></returns>
        public static ImageNews Get(int id, ModelUnibookContainer objContex)
        {
            ImageNews imagenewsReturn = null;
            try
            {
                imagenewsReturn = (from imagenews in objContex.ImageNews
                                   where imagenews.Deleted == false && imagenews.ImageId == id
                                   select imagenews).Single<ImageNews>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return imagenewsReturn;
        }

        /// <summary>
        /// Insert a ImageNews
        /// </summary>
        /// <param name="ImageNews"></param>
        /// <param name="objContex"></param>
        public static void Insert(ImageNews imagenews, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.ImageNews.Add(imagenews);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a ImageNews
        /// </summary>
        /// <param name="ImageNews"></param>
        /// <param name="objContex"></param>
        public static void Update(ImageNews imagenews, ModelUnibookContainer objContex)
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
        /// Deleted a ImageNews
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNews imagenews = objContex.ImageNews.Find(id);
                imagenews.Deleted = true;
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
