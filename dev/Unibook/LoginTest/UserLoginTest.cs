using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.LoginBrl;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.LoginTest
{
    /// <summary>
    /// Test to login module
    /// </summary>
    [TestClass]
    public class UserLoginTest
    {
        private ModelUnibookContainer container = new ModelUnibookContainer();

        [TestMethod]
        public void TestLogin()
        {
            UserDto user = new UserDto()
            {
                Email = "prueba@gmail.com",
                Password = new PasswordDto() { Psw = "hola"}
            };
            UserDto currentUser = new UserDto()
            {
                Email = "prueba@gmail.com",
                Password = new PasswordDto() { Psw = "hola" }
            };
            UserBrl.Insert(currentUser, container);

            Assert.Equals(true, UserLoginBrl.Login(user, container));
        }

        [TestMethod]
        public void TestChangePassword()
        {
            UserDto currentUser = new UserDto()
            {
                Email = "prueba@gmail.com",
                Password = new PasswordDto() { Psw = "hola" },
                UserId = 50
            };
            UserBrl.Insert(currentUser, container);

            PasswordDto user = new PasswordDto()
            {
                Id = 50,
                NewPassword = "12345",
                Psw = "hola" 
            };
            Assert.Equals(true, UserLoginBrl.ChangePassword(user, container));
        }
    }
}