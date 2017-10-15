using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace AcademicTest
{
    class CategoryAcademicTest
    {
        static void MainCategory(string[] args)
        {
            CategoryAcademic categoryAcademic = new CategoryAcademic() { Name = "Tecnologia", Deleted = false};
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            CategoryAcademicBrl.Insert(categoryAcademic, Objectcontext);

            CategoryAcademic categoryAcademicGet = CategoryAcademicBrl.Get(1, Objectcontext);
            categoryAcademicGet.Name = "Informatica";
            CategoryAcademicBrl.Update(Objectcontext);

            CategoryAcademicBrl.Delete(1, Objectcontext);
        }
    }
}
