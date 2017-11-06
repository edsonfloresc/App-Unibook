using System;
using System.Linq;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto.Models;

namespace Univalle.Fie.Sistemas.UniBook.LoginDal
{
    /// <summary>
    /// Data Access Layer to user login
    /// </summary>
    public class UserLoginDal
    {
        #region Methods

        /// <summary>
        /// Verify if data it's correct to login in to Unibook.
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="objContext"></param>
        /// <returns>Boolean value that represents if data it's correct or not.</returns>
        public static bool Login(LoginModel user, ModelUnibookContainer objContext)
        {
            try
            {
                User result = (from currentUser in objContext.User
                               where currentUser.Email == user.Email &&
                               currentUser.Password == user.Password
                               select currentUser).Single();
                return result != null ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Change password from user.
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="objContext"></param>
        public static bool ChangePassword(ChangePasswordModel user, ModelUnibookContainer objContext)
        {
            try
            {
                objContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        #endregion Methods
    }
}