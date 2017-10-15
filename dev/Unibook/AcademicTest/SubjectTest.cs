using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace AcademicTest
{
    class SubjectTest
    {
        static void MainSubject(string[] args)
        {
            Subject subject = new Subject() {Name="Fisica", Description = "DescriptionTest",  Deleted = false };
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            SubjectBrl.Insert(subject, Objectcontext);

            Subject subjectGet = SubjectBrl.Get(1, Objectcontext);
            subjectGet.Description = "PruebaTestUpdate";
            SubjectBrl.Update(Objectcontext);

            SubjectBrl.Delete(1, Objectcontext);
        }
    }
}
