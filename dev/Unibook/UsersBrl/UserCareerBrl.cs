using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using UsersDal;

namespace UsersBrl
{
    public class UserCareerBrl
    {
        /// <summary>
        /// Create a new user Career
        /// </summary>
        /// <param name="userCareer"></param>
        /// <param name="objContex"></param>
        public static void Insertar(UserCareer userCareer, ModelUnibookContainer objContex)
        {
            try
            {
                UserCareerDal.Insert(userCareer, objContex);
            }
            catch (Exception)
            {


            }
        }

        /// <summary>
        /// Get a user Career with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static UserCareer Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return UserCareerDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="userCareer"></param>
        /// <param name="objContex"></param>
        public static void Update(UserCareer userCareer, ModelUnibookContainer objContex)
        {
            try
            {
                UserCareerDal.Update(userCareer, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
