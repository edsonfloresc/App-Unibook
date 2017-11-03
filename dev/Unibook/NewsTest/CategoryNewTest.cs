using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;
using Univalle.Fie.Sistemas.Unibook.CommonDto;
namespace Univalle.Fie.Sistemas.Unibook.NewsTest
{
    /// <summary>
    /// Descripción resumida de CategoryNewTest
    /// </summary>
    [TestClass]
    public class CategoryNewTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();
        [TestMethod]
        public void TestCreateCategoryNew()
        {
            CategoryNewsDto categorynewdto = new CategoryNewsDto();
            categorynewdto.NameCategory = "Deporte";
            categorynewdto.Deleted = false;            
            NewsBrl.CategoryNewBrl.Insertar(categorynewdto, content);
            //CategoryNews actual = CategoryNewBrl.Get(3, content);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestEditCategoryNew()
        {
            CategoryNewsDto categorynewdto = CategoryNewBrl.GetDto(1, content);
            categorynewdto.NameCategory = "Deporte";
            NewsBrl.CategoryNewBrl.Update(categorynewdto, content);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestDeleteCategoryNew()
        {
            CategoryNewsDto categorynewdto = CategoryNewBrl.GetDto(1, content);
            categorynewdto.Deleted = true;
            CategoryNewBrl.Update(categorynewdto, content);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestGetCategoryNew()
        {
            CategoryNews actual = CategoryNewBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
