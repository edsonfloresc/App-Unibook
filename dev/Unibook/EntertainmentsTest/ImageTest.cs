using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;


namespace Univalle.Fie.Sistemas.UniBook.EntertainmentsTest
{
    [TestClass]
    public class ImageTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateImage()
        {


            ImageEnterDto image = new ImageEnterDto();
            image.PathImage = "Ejemplo de path";
            image.Deleted = false;
            ImageBrl.Insert(image, content);
            ImageEnterDto actual = ImageBrl.GetDto(1, content);
            Assert.AreEqual(actual, actual);

        }

        [TestMethod]
        public void TestEditImage()
        {
            ImageEnterDto image = ImageBrl.GetDto(1, content);
            image.PathImage = "cambiamos de path";
            ImageBrl.Update(image, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteImage()
        {
            ImageEnter image = ImageBrl.Get(1, content);
            ImageBrl.Delete(int.Parse(image.ImageId.ToString()), content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetImage()
        {
            ImageEnter actual = ImageBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }

    }
}
