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
    class CommentAcademicTest
    {
        static void MainComment(string[] args)
        {
            CommentAcademic commentAcademic = new CommentAcademic() { Description = "PruebaTest",DateComment=DateTime.Now, Deleted = false};           
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            commentAcademic.PublicationAcademic = PublicationAcademicBrl.Get(1, Objectcontext);
            commentAcademic.User = UserBrl.Get(1, Objectcontext);
            CommentAcademicBrl.Insert(commentAcademic, Objectcontext);

            CommentAcademic commentAcademicGet = CommentAcademicBrl.Get(1, Objectcontext);
            commentAcademicGet.Description = "PruebaTestUpdate";
            CommentAcademicBrl.Update(Objectcontext);

            CommentAcademicBrl.Delete(1, Objectcontext);
        }
    }
}
