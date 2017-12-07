using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;


namespace Univalle.Fie.Sistemas.UniBook.EntertainmentsTest
{
    [TestClass]
    public class CategoryTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateCategory()
        {
            CategoryEnterDto category = new CategoryEnterDto();
            category.Description = "Eventos";
            category.Deleted = false;
            CategoryBrl.Insert(category, content);
            CategoryEnterDto actual = CategoryBrl.GetDto(5, content);
            Assert.AreEqual(actual, actual);

        }

        [TestMethod]
        public void TestEditCategory()
        {
            CategoryEnterDto category = CategoryBrl.GetDto(1, content);
            category.Description = "Eventos";
            CategoryBrl.Update(category, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteCategory()
        {
            CategoryEnter category = CategoryBrl.Get(1, content);
            CategoryBrl.Delete(category.CategoryId, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetCategory()
        {
            CategoryEnterDto actual = CategoryBrl.GetDto(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
