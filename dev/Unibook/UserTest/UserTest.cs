using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace UserTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestCreatUser()
        {
            User user = new User();
            user.Role = new Role() { Name = "Administrador"};
            user.Password = "123";
            user.Deleted = false;
            user.Email = "roberto@gmail.com";
            ModelUnibookContainer container = new ModelUnibookContainer();
            UsersBrl.UserBrl.Insertar(user, container);
        }
    }
}
