using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class UserTest
    {

        ModelUnibookContainer container = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreatUser()
        {
            User user = new User();
            user.Password = "123";
            user.Deleted = false;   
            user.Email = "rodrigosiles@gmail.com";
            user.Role = RoleBrl.Get(1, container);
            user.Person = PersonBrl.Get(1, container);
            UserBrl.Insertar(user, container);
        }

        [TestMethod]
        public void TestUpdatetUser()
        {
            User user = UserBrl.Get(1, container);
            user.Email = "robertoNogales@gmail.com";
            UserBrl.Update(user, container);
        }
    }
}
