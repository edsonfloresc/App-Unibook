using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsDal;
using Univalle.Fie.Sistemas.Unibook.CommonDto;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class CategoryNewBrl
    {
        /// <summary>
        /// Create a new CategoryNews
        /// </summary>
        /// <param name="CategoryNews"></param>
        /// <param name="objContex"></param>
        public static void Insertar(CategoryNewsDto categorynewsdto, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryNews categorynews = new CategoryNews();
                categorynews.NameCategory = categorynewsdto.NameCategory;
                categorynews.Deleted = categorynewsdto.Deleted;
                CategoryNewDal.Insert(categorynews, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a CategoryNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CategoryNewsDto GetDto(int id, ModelUnibookContainer objContex)
        {
            CategoryNewsDto categorynewsdto = null;
            try
            {
                CategoryNews categorynews = CategoryNewDal.Get(id, objContex);
                categorynewsdto = new CategoryNewsDto();
                categorynewsdto.NameCategory = categorynews.NameCategory;
                categorynewsdto.Deleted = categorynews.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categorynewsdto;
        }

        /// Get a CategoryNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CategoryNews Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return CategoryNewDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="CategoryNews"></param>
        /// <param name="objContex"></param>
        public static void Update(CategoryNewsDto categorynewsdto, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryNews categorynews = CategoryNewDal.Get(categorynewsdto.CategoryId, objContex);
                categorynews.NameCategory = categorynewsdto.NameCategory;
                categorynews.Deleted = categorynewsdto.Deleted;
                CategoryNewDal.Update(categorynews, objContex);
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
                CategoryNewDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
