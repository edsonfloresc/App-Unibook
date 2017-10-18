using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsDal;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class NewBrl
    {
        /// <summary>
        /// Create a new News
        /// </summary>
        /// <param name="News"></param>
        /// <param name="objContex"></param>
        public static void Insertar(News news, ModelUnibookContainer objContex)
        {
            try
            {
                NewDal.Insert(news, objContex);
            }
            catch (Exception)
            {

            }
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
        public static void Update(News news, ModelUnibookContainer objContex)
        {
            try
            {
                NewDal.Update(news, objContex);
            }
            catch (Exception)
            {

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
