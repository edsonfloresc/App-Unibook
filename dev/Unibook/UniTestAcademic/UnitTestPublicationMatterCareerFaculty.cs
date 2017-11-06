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
    /// Descripción resumida de UnitTestPublicationMatterCareerFaculty
    /// </summary>
    [TestClass]
    public class UnitTestPublicationMatterCareerFaculty
    {       
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            PublicationMatterCareerFacultyDto publicationMatterCareerFacultyDto = new PublicationMatterCareerFacultyDto();           
            publicationMatterCareerFacultyDto.PublicationAcademic = PublicationAcademicBrl.GetDto(1, objContex);
            publicationMatterCareerFacultyDto.Subject = SubjectBrl.GetDto(1, objContex);
            publicationMatterCareerFacultyDto.Career = CareerBrl.GetDto(1, objContex);
            publicationMatterCareerFacultyDto.Faculty = FacultyBrl.GetDto(1, objContex);
            PublicationMatterCareerFacultyBrl.Insert(publicationMatterCareerFacultyDto, objContex);

            PublicationMatterCareerFacultyDto publicationMatterCareerFacultyGetDto = PublicationMatterCareerFacultyBrl.GetDto(1, objContex);
            publicationMatterCareerFacultyDto.PublicationAcademic = PublicationAcademicBrl.GetDto(2, objContex);
            publicationMatterCareerFacultyDto.Subject = SubjectBrl.GetDto(2, objContex);
            publicationMatterCareerFacultyDto.Career = CareerBrl.GetDto(2, objContex);
            publicationMatterCareerFacultyDto.Faculty = FacultyBrl.GetDto(2, objContex);
            PublicationMatterCareerFacultyBrl.Update(publicationMatterCareerFacultyGetDto,objContex);
        }
    }
}
