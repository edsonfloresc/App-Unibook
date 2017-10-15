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
    class SubjectCareerTest
    {
        static void MainSubjectCareer(string[] args)
        {
            SubjectCareer subjectCareer = new SubjectCareer() {};
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            subjectCareer.Subject = SubjectBrl.Get(1, Objectcontext);
            subjectCareer.Career = CareerBrl.Get(1, Objectcontext);
            SubjectCareerBrl.Insert(subjectCareer, Objectcontext);

            SubjectCareer subjectCareerGet = SubjectCareerBrl.Get(1, Objectcontext);
      
            SubjectCareerBrl.Update(Objectcontext);

        }
    }
}
