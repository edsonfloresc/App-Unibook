using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace UniTestAcademic
{
    /// <summary>
    /// Descripción resumida de UnitTestPerson
    /// </summary>
    [TestClass]
    public class UnitTestPerson
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            Person person = new Person() { Name = "UnitTestNameInsert", LastName = "UnitTestLastNameInsert", BirthDay = DateTime.Now, Deleted = false };           
            PersonBrl.Insert(person, objContex);

            Person personGet = PersonBrl.Get(1, objContex);
            personGet.Name = "PruebaTestUpdate";
            personGet.LastName = "UnitTestLastNameUpdate";
            person.BirthDay = DateTime.Now;
            PersonBrl.Update(objContex);

            PersonBrl.Delete(1, objContex);
        }
    }
}
