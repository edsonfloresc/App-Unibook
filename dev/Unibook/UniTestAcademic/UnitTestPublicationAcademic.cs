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
    /// Descripción resumida de UnitTestPublicationAcademic
    /// </summary>
    [TestClass]
    public class UnitTestPublicationAcademic
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            PublicationAcademic publicationAcademic = new PublicationAcademic() { Description = "UnitTestDescriptionInsert",Image = "UnitTestImageInsert", DatePublication = DateTime.Now, Deleted = false };           
            publicationAcademic.CategoryAcademic = CategoryAcademicBrl.Get(1, objContex);
            publicationAcademic.User = UserBrl.Get(1, objContex);
            PublicationAcademicBrl.Insert(publicationAcademic, objContex);

            PublicationAcademic publicationAcademicGet = PublicationAcademicBrl.Get(1, objContex);
            publicationAcademicGet.Description = "UnitTestDescriptionUpdate";
            publicationAcademicGet.Image = "UnitTestImageUpdate";
            publicationAcademicGet.DatePublication = DateTime.Now;
            PublicationAcademicBrl.Update(objContex);

            PublicationAcademicBrl.Delete(1, objContex);
        }
    }
}
