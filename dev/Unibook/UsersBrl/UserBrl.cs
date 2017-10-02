using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using UsersDal;

namespace UsersBrl
{
    public class UserBrl
    {
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="objContex"></param>
        public static void Insertar(User user, ModelUnibookContainer objContex)
        {
            try
            {
                UserDal.Insert(user, objContex);
            }
            catch (Exception )
            {

            }
        }

        /// <summary>
        /// Get a user with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static User Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return UserDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="user"></param>
        /// <param name="objContex"></param>
        public static void Update(User user, ModelUnibookContainer objContex)
        {
            try
            {
                UserDal.Update(user, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                UserDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
