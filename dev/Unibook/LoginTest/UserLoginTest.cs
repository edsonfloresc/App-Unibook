using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.CommonDto.Models;
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
            LoginModel user = new LoginModel()
            {
                Email = "prueba@gmail.com",
                Password = "Hola"
            };
            UserDto currentUser = new UserDto()
            {
                Email = "prueba@gmail.com",
                Password = "Hola",
            };
            UserBrl.Insertar(currentUser, container);

            Assert.Equals(true, UserLoginBrl.Login(user, container));
        }

        [TestMethod]
        public void TestChangePassword()
        {
            UserDto currentUser = new UserDto()
            {
                Email = "prueba@gmail.com",
                Password = "Hola",
                UserId = 50
            };
            UserBrl.Insertar(currentUser, container);

            ChangePasswordModel user = new ChangePasswordModel()
            {
                Id = 50,
                NewPassword = "12345",
                OldPassword = "Hola"
            };
            Assert.Equals(true, UserLoginBrl.ChangePassword(user, container));
        }
    }
}