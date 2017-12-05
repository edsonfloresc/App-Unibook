using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.LoginDal;

namespace Univalle.Fie.Sistemas.UniBook.LoginBrl
{
    public class UserLoginBrl
    {
        public static bool Login(UserDto user, ModelUnibookContainer objContext)
        {
            return UserLoginDal.Login(user, objContext);
        }

        public static bool ChangePassword(PasswordDto user, ModelUnibookContainer objContext)
        {
            return UserLoginDal.ChangePassword(user, objContext);
        }
    }
}