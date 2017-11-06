using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.UniTestAcademic
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
            SubjectCareerDto subjectCareerDto = new SubjectCareerDto();
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            subjectCareerDto.Subject = SubjectBrl.GetDto(1, objContex);
            subjectCareerDto.Career = CareerBrl.GetDto(1, objContex);
            SubjectCareerBrl.Insert(subjectCareerDto, objContex);

            SubjectCareerDto subjectCareerGetDto = SubjectCareerBrl.GetDto(1, objContex);
            subjectCareerGetDto.Subject = SubjectBrl.GetDto(2, objContex);
            subjectCareerGetDto.Career = CareerBrl.GetDto(2, objContex);

            SubjectCareerBrl.Update(subjectCareerGetDto,objContex);
        }
    }
}
