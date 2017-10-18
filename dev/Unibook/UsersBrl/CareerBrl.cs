using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class CareerBrl
    {
        /// <summary>
        /// Create a new career
        /// </summary>
        /// <param name="career"></param>
        /// <param name="objContex"></param>
        public static void Insertar(Career career, ModelUnibookContainer objContex)
        {
            try
            {
                CareerDal.Insert(career, objContex);
            }
            catch (Exception)
            {


            }
        }

        /// <summary>
        /// Get a career with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Career Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return CareerDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="career"></param>
        /// <param name="objContex"></param>
        public static void Update(Career career, ModelUnibookContainer objContex)
        {
            try
            {
                CareerDal.Update(career, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Delete a career
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CareerDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
