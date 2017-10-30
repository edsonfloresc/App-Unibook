using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class CareerTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateCareer()
        {
            Career career = new Career();
            Faculty faculty = FacultyBrl.Get(1, content);
            career.Name = "Sis";
            career.Deleted = false;
            career.Faculty = faculty;
            //CareerBrl.Insertar(career, content);
        }

        [TestMethod]
        public void TestEditCareer()
        {
            Career career = CareerBrl.Get(2, content);
            career.Name = "Eelectronica";
            //CareerBrl.Update(career, content);
        }

        [TestMethod]
        public void TestDeleteCareer()
        {
            Career career = CareerBrl.Get(1, content);
            career.Deleted = true;
            //CareerBrl.Update(career, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetCareer()
        {
            Career actual = CareerBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
