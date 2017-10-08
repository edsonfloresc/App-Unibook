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
            role.Name = "Administrador";
            role.Deleted = false;
            ModelUnibookContainer content = new ModelUnibookContainer();
            RoleBrl.Insertar(role, content);
            Assert.AreEqual(true, true);
        }
    }
}
