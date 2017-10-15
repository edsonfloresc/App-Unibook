using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace UniTestAcademic
{
    /// <summary>
    /// Descripción resumida de UnitTestSubject
    /// </summary>
    [TestClass]
    public class UnitTestSubject
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            Subject subject = new Subject() { Name = "UnitTestNameInsert", Description = "UnitTestDescriptionInsert", Deleted = false };
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            SubjectBrl.Insert(subject, objContex);

            Subject subjectGet = SubjectBrl.Get(1, objContex);
            subject.Name = "UnitTestNameUpdate";
            subjectGet.Description = "UnitTestDescriptionUpdate";
            SubjectBrl.Update(objContex);

            SubjectBrl.Delete(1, objContex);
        }
    }
}
