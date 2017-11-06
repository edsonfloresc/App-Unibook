using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto.Models;
using Univalle.Fie.Sistemas.UniBook.LoginDal;

namespace Univalle.Fie.Sistemas.UniBook.LoginBrl
{
    public class UserLoginBrl
    {
        public static bool Login(LoginModel user, ModelUnibookContainer objContext)
        {
            return UserLoginDal.Login(user, objContext);
        }

        public static bool ChangePassword(ChangePasswordModel user, ModelUnibookContainer objContext)
        {
            return UserLoginDal.ChangePassword(user, objContext);
        }
    }
}