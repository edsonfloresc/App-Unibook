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
    /// Descripción resumida de UnitTestPublicationMatterCareerFaculty
    /// </summary>
    [TestClass]
    public class UnitTestPublicationMatterCareerFaculty
    {       
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            PublicationMatterCareerFaculty publicationMatterCareerFaculty = new PublicationMatterCareerFaculty() { };           
            publicationMatterCareerFaculty.PublicationAcademic = PublicationAcademicBrl.Get(1, objContex);
            publicationMatterCareerFaculty.Subject = SubjectBrl.Get(1, objContex);
            publicationMatterCareerFaculty.Career = CareerBrl.Get(1, objContex);
            publicationMatterCareerFaculty.Faculty = FacultyBrl.Get(1, objContex);
            PublicationMatterCareerFacultyBrl.Insert(publicationMatterCareerFaculty, objContex);

            PublicationMatterCareerFaculty publicationMatterCareerFacultyGet = PublicationMatterCareerFacultyBrl.Get(1, objContex);
            PublicationMatterCareerFacultyBrl.Update(objContex);
        }
    }
}
