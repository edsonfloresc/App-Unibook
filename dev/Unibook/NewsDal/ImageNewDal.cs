using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.NewsDal
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
                imagenewsReturn = (from imagenews in objContex.ImageNewsSet
                                   where imagenews.Deleted == false && imagenews.ImageId == id
                                   select imagenews).Single<ImageNews>();
            }
            catch (Exception ex)
            {
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
                objContex.ImageNewsSet.Add(imagenews);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
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
                ImageNews imagenews = objContex.ImageNewsSet.Find(id);
                imagenews.Deleted = true;
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
