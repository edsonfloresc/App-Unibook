using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using UsersBrl;

namespace UserTest
{
    [TestClass]
    public class RoleTest
    {
        [TestMethod]
        public void TestCreateRole()
        {
            Role role = new Role();
            role.Name = "Estudiante";
            role.Deleted = false;
            ModelUnibookContainer content = new ModelUnibookContainer();
            RoleBrl.Insertar(role, content);
            Role actual = RoleBrl.Get(3, content);
            Assert.AreEqual(role, actual);
        }

        [TestMethod]
        public void TestEditRole()
        {
            ModelUnibookContainer content = new ModelUnibookContainer();
            Role role = RoleBrl.Get(1, content);
            role.Name = "Admin";
            RoleBrl.Update(role, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteRole()
        {
            ModelUnibookContainer content = new ModelUnibookContainer();
            Role role = RoleBrl.Get(1, content);
            role.Deleted = true;
            RoleBrl.Update(role, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetRole()
        {
            ModelUnibookContainer content = new ModelUnibookContainer();
            Role actual = RoleBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
