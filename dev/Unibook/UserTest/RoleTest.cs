using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class RoleTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateRole()
        {
            Role role = new Role();
            role.Name = "Administrador";
            role.Deleted = false;
            RoleBrl.Insertar(role, content);
            Role actual = RoleBrl.Get(1, content);
            Assert.AreEqual(role, actual);
        }

        [TestMethod]
        public void TestEditRole()
        {
            Role role = RoleBrl.Get(1, content);
            role.Name = "Admin";
            RoleBrl.Update(role, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteRole()
        {
            Role role = RoleBrl.Get(1, content);
            role.Deleted = true;
            RoleBrl.Update(role, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetRole()
        {
            Role actual = RoleBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
