using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace UniTestAcademic
{
    /// <summary>
    /// Descripción resumida de UnitTestContact
    /// </summary>
    [TestClass]
    public class UnitTestContact
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            Contact contact = new Contact() { Data = "UnitTestDataInsert", Description = "UnitTestDescriptionInsert", Deleted = false };           
            contact.Person = PersonBrl.Get(1, objContex);
            ContactBrl.Insert(contact, objContex);

            Contact contactGet = ContactBrl.Get(1, objContex);
            contactGet.Data = "UnitTestDataUpdate";
            contactGet.Description = "UniTestDescriptionUpdate";
            ContactBrl.Update(objContex);

            ContactBrl.Delete(1, objContex);
        }
    }
}
