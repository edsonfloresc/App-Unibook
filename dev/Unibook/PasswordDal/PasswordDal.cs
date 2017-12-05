using System;
using System.Linq;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.PasswordDal
{
    public class PasswordDal
    {
        #region Methods

        /// <summary>
        /// Get password by user id
        /// </summary>
        /// <param name="userId">Id passwordId to search</param>
        /// <returns></returns>
        public static Password Get(long userId, ModelUnibookContainer objContex)
        {
            Password actual = null;

            try
            {
                actual = (from pass in objContex.Password
                          where pass.State == 1 && pass.User.UserId == userId
                          select pass).Single<Password>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            return actual;
        }

        /// <summary>
        /// Add new password.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="objContex"></param>
        public static bool AddNewPassword(Password password,
            ModelUnibookContainer objContex)
        {
            try
            {
                Password old = (from pass in objContex.Password
                                where pass.User.UserId == password.User.UserId
                                && pass.State == 1
                                select pass)
                                .SingleOrDefault<Password>();
                password.Date = new DateTime();
                password.State = 1;
                if (old != null)
                {
                    old.State = 0;
                    objContex.Password.Add(password);
                }
                else
                {
                    objContex.Password.Add(password);
                }
                objContex.SaveChanges();
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