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
    class PublicationAcademicTest
    {
        static void MainPublicationAcademic(string[] args)
        {
            PublicationAcademic publicationAcademic = new PublicationAcademic() { Description = "DescriptionTest", DatePublication = DateTime.Now, Deleted = false};
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            publicationAcademic.CategoryAcademic = CategoryAcademicBrl.Get(1, Objectcontext);
            publicationAcademic.User = UserBrl.Get(1, Objectcontext);
            PublicationAcademicBrl.Insert(publicationAcademic, Objectcontext);

            PublicationAcademic publicationAcademicGet = PublicationAcademicBrl.Get(1, Objectcontext);
            publicationAcademicGet.Description = "PruebaTestUpdate";
            PublicationAcademicBrl.Update(Objectcontext);

            PublicationAcademicBrl.Delete(1, Objectcontext);
        }
    }
}
