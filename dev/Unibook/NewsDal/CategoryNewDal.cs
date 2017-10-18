using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.NewsDal
{
    public class CategoryNewDal
    {
        #region metodos

        /// <summary>
        /// Get CategoryNews by id
        /// </summary>
        /// <param name="id">Id CategoryNews to search</param>
        /// <returns></returns>
        public static CategoryNews Get(int id, ModelUnibookContainer objContex)
        {
            CategoryNews categorynewsReturn = null;
            try
            {
                categorynewsReturn = (from categorynews in objContex.CategoryNewsSet
                                      where categorynews.Deleted == false && categorynews.CategoryId == id
                                      select categorynews).Single<CategoryNews>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categorynewsReturn;
        }

        /// <summary>
        /// Insert a CategoryNews
        /// </summary>
        /// <param name="CategoryNews"></param>
        /// <param name="objContex"></param>
        public static void Insert(CategoryNews categorynews, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CategoryNewsSet.Add(categorynews);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a CategoryNews
        /// </summary>
        /// <param name="CategoryNews"></param>
        /// <param name="objContex"></param>
        public static void Update(CategoryNews categorynews, ModelUnibookContainer objContex)
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
        /// Deleted a CategoryNews
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryNews categorynews = objContex.CategoryNewsSet.Find(id);
                categorynews.Deleted = true;
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
