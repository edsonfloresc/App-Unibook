using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class GenderTest
    {

        ModelUnibookContainer container = new ModelUnibookContainer();

        [TestMethod]
        public void TestGettGender()
        {
            Gender actual = GenderBrl.Get(1, container);
        }
    }
}
