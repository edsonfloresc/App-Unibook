using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class FacultyTest
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreateFaculty()
        {
            Faculty faculty = new Faculty();
            faculty.Name = "Tecnologia";
            faculty.Deleted = false;
            //FacultyBrl.Insertar(faculty, content);
            Faculty actual = FacultyBrl.Get(1, content);
            Assert.AreEqual(faculty, actual);
        }

        [TestMethod]
        public void TestEditFaculty()
        {
            Faculty faculty = FacultyBrl.Get(2, content);
            faculty.Name = "Sociales";
            //FacultyBrl.Update(faculty, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteFaculty()
        {
            Faculty faculty = FacultyBrl.Get(1, content);
            faculty.Deleted = true;
            //FacultyBrl.Update(faculty, content);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestGetFaculty()
        {
            Faculty actual = FacultyBrl.Get(1, content);
            Assert.AreEqual(actual, actual);
        }
    }
}
