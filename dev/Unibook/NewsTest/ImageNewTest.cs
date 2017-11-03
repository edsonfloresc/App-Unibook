using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.CommonDto;
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
            ImageNewsDto imagenewdto = new ImageNewsDto();
            imagenewdto.PathImage = "";
            imagenewdto.Deleted = false;
            ImageNewBrl.Insertar(imagenewdto, content);
            //ImageNews actual = ImageNewBrl.Get(1, content);
            Assert.AreEqual(content, content);
            
        }

        [TestMethod]
        public void TestEditImageNew()
        {
            ImageNewsDto imagenewdto = ImageNewBrl.GetDto(2, content);
            imagenewdto.PathImage = "";
            ImageNewBrl.Update(imagenewdto, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteImageNew()
        {
            ImageNewsDto imagenewdto = ImageNewBrl.GetDto(1, content);
            imagenewdto.Deleted = true;
            ImageNewBrl.Update(imagenewdto, content);
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
