using System;
using System.Linq;
using System.Text.RegularExpressions;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.PasswordBrl
{
    public class PasswordBrl
    {
        #region Methods

        /// <summary>
        /// Get password by user id
        /// </summary>
        /// <param name="userId">Id passwordId to search</param>
        /// <returns></returns>
        public static PasswordDto Get(int userId, ModelUnibookContainer objContex)
        {
            PasswordDto pass = null;
            try
            {
                Password actual = PasswordDal.PasswordDal.Get(1, objContex);
                pass.PasswordId = actual.PasswordId;
                pass.Psw = actual.Psw;
                pass.State = actual.State;
                pass.Date = actual.Date;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pass;
        }

        /// <summary>
        /// Add new password.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="objContex"></param>
        public static bool AddNewPassword(PasswordDto password,
            ModelUnibookContainer objContex)
        {
            Password actual = PasswordDal.PasswordDal.Get(password.UserId, objContex);
            if (actual.Psw == password.Psw)
            {
                Password exists = (from psw in objContex.Password
                                   where psw.User.UserId == password.UserId &&
                                    psw.Psw == password.NewPassword
                                   select psw).SingleOrDefault();
                if (exists == null)
                {
                    bool result = Regex.IsMatch(password.NewPassword,
                        "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$");
                    if (result)
                    {

                        Password newPassword = new Password()
                        {
                            Psw = password.NewPassword,
                            User = new User() { UserId = password.UserId }
                        };
                        return PasswordDal.PasswordDal.AddNewPassword(actual, objContex);
                    } else
                    {
                        return false;
                        throw new Exception("The new password should have at least one uppercase, one lowercase and one number and at least eight characteres.");
                    }
                }
                else
                {
                    return false;
                    throw new Exception("The new password must be different from any other password you used.");
                }
            }
            else
            {
                return false;
                throw new Exception("Failed to change the password");
            }
        }

        #endregion Methods
    }
}