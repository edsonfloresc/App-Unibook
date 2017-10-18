using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

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
            CategoryNews categorynew = new CategoryNews();
            categorynew.NameCategory = "Deporte";
            categorynew.Deleted = false;            
            NewsBrl.CategoryNewBrl.Insertar(categorynew, content);
            CategoryNews actual = CategoryNewBrl.Get(1, content);
            Assert.AreEqual(categorynew, actual);
        }
        [TestMethod]
        public void TestEditCategoryNew()
        {
            CategoryNews categorynew = CategoryNewBrl.Get(2, content);
            categorynew.NameCategory = "Cultural";
            CategoryNewBrl.Update(categorynew, content);
            Assert.AreEqual(true, true);
        }
        public void TestDeleteCategoryNew()
        {
            CategoryNews categorynew = CategoryNewBrl.Get(1, content);
            categorynew.Deleted = true;
            CategoryNewBrl.Update(categorynew, content);
            Assert.AreEqual(true, true);
        }
        public void TestGetCategoryNew()
        {
            CategoryNews actual = CategoryNewBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
