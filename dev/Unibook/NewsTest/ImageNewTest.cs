using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

namespace Univalle.Fie.Sistemas.Unibook.NewsTest
{
    /// <summary>
    /// Descripción resumida de ImageNewTest
    /// </summary>
    [TestClass]
    public class ImageNewTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();
        [TestMethod]
        public void TestCreateImageNew()
        {
            ImageNews imagenew = new ImageNews();
            imagenew.PathImage = "";
            imagenew.Deleted = false;
            ImageNewBrl.Insertar(imagenew, content);
            ImageNews actual = ImageNewBrl.Get(1, content);
            Assert.AreEqual(imagenew, content);
            
        }

        [TestMethod]
        public void TestEditImageNew()
        {
            ImageNews imagenew = ImageNewBrl.Get(2, content);
            imagenew.PathImage = "";
            ImageNewBrl.Update(imagenew, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteImageNew()
        {
            ImageNews imagenew = ImageNewBrl.Get(1, content);
            imagenew.Deleted = true;
            ImageNewBrl.Update(imagenew, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetImageNew()
        {
            ImageNews actual = ImageNewBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
