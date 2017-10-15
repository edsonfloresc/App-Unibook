using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using UsersBrl;

namespace UniTestAcademic
{
    /// <summary>
    /// Descripción resumida de UnitTestSubjectCareer
    /// </summary>
    [TestClass]
    public class UnitTestSubjectCareer
    {     
        [TestMethod]
        public void TestMethodBrl()
        {
            SubjectCareer subjectCareer = new SubjectCareer() { };
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            subjectCareer.Subject = SubjectBrl.Get(1, objContex);
            subjectCareer.Career = CareerBrl.Get(1, objContex);
            SubjectCareerBrl.Insert(subjectCareer, objContex);

            SubjectCareer subjectCareerGet = SubjectCareerBrl.Get(1, objContex);

            SubjectCareerBrl.Update(objContex);
        }
    }
}
