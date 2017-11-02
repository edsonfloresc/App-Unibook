using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class UserCareerTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateUserCareer()
        {
            UserCareer userCareer = new UserCareer();
            User user = UserBrl.Get(1, content);
            Career career = CareerBrl.Get(1, content);
            userCareer.Career = career;
            userCareer.User = user;
            //UserCareerBrl.Insertar(userCareer, content);
        }

        [TestMethod]
        public void TestEditUserCareer()
        {
            UserCareer userCareer = UserCareerBrl.Get(1, content);
            User user = UserBrl.Get(2, content);
            userCareer.User = user;
            //UserCareerBrl.Update(userCareer, content);
        }
    }
}
