using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using UsersBrl;
namespace AcademicTest
{
    class PublicationMatterCareerFacultyTest
    {
        static void MainPublicationMatterCareerFaculty(string[] args)
        {
            PublicationMatterCareerFaculty publicationMatterCareerFaculty = new PublicationMatterCareerFaculty() {};
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            publicationMatterCareerFaculty.PublicationAcademic = PublicationAcademicBrl.Get(1, Objectcontext);
            publicationMatterCareerFaculty.Subject = SubjectBrl.Get(1, Objectcontext);
            publicationMatterCareerFaculty.Career = CareerBrl.Get(1, Objectcontext);
            publicationMatterCareerFaculty.Faculty = FacultyBrl.Get(1, Objectcontext);
            PublicationMatterCareerFacultyBrl.Insert(publicationMatterCareerFaculty, Objectcontext);

            PublicationMatterCareerFaculty publicationMatterCareerFacultyGet = PublicationMatterCareerFacultyBrl.Get(1, Objectcontext);
            PublicationMatterCareerFacultyBrl.Update(Objectcontext);
  
        }
    }
}
