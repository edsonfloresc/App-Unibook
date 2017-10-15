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
    /// Descripción resumida de UnitTestCommentAcademic
    /// </summary>
    [TestClass]
    public class UnitTestCommentAcademic
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            CommentAcademic commentAcademic = new CommentAcademic() { Description = "UnitTestDescriptionInsert", DateComment = DateTime.Now, Deleted = false };            
            commentAcademic.PublicationAcademic = PublicationAcademicBrl.Get(1, objContex);
            commentAcademic.User = UserBrl.Get(1, objContex);
            CommentAcademicBrl.Insert(commentAcademic, objContex);

            CommentAcademic commentAcademicGet = CommentAcademicBrl.Get(1, objContex);
            commentAcademicGet.Description = "UnitTestDescriptionUpdate";
            commentAcademicGet.DateComment = DateTime.Now;
            CommentAcademicBrl.Update(objContex);

            CommentAcademicBrl.Delete(1, objContex);
        }
    }
}
