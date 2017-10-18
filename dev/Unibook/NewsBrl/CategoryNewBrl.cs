using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsDal;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class CategoryNewBrl
    {
        /// <summary>
        /// Create a new CategoryNews
        /// </summary>
        /// <param name="CategoryNews"></param>
        /// <param name="objContex"></param>
        public static void Insertar(CategoryNews categorynews, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryNewDal.Insert(categorynews, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
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
        public static void Update(CategoryNews categorynews, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryNewDal.Update(categorynews, objContex);
            }
            catch (Exception)
            {

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
