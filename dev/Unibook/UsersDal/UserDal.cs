using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class UserDal
    {
        #region Methods

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns></returns>
        public static User Get(long id, ModelUnibookContainer objContex)
        {
            User userReturn = null;


            try
            {
                userReturn = (from user in objContex.UserSet
                              where user.Deleted == false && user.UserId == id
                              select user).Single<User>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                objContex.UserSet.Add(user);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
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
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                User user = objContex.UserSet.Find(id);
                user.Deleted = true;
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
