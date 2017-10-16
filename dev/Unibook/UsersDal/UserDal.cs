using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace UsersDal
{
    public class UserDal
    {
        #region metodos

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns></returns>
        public static User Get(int id, ModelUnibookContainer objContex)
        {
            User userReturn = null;


            try
            {
                userReturn = (from user in objContex.User
                              where user.Deleted == false && user.UserId == id
                              select user).Single<User>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userReturn;
        }

        /// <summary>
        /// Insert a User
        /// </summary>
        /// <param name="user"></param>
        /// <param name="objContex"></param>
        public static void Insert(User user, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.User.Add(user);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="objContex"></param>
        public static void Update(User user, ModelUnibookContainer objContex)
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
        /// Deleted a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                User user = objContex.User.Find(id);
                user.Deleted = true;
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
