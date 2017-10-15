using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace UniTestAcademic
{
    /// <summary>
    /// Descripción resumida de UnitTestCategoryAcademic
    /// </summary>
    [TestClass]
    public class UnitTestCategoryAcademic
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            CategoryAcademic categoryAcademic = new CategoryAcademic() { Name = "UnitTestNameInsert", Description = "UnitTestDescriptionInsert", Deleted = false};          
            CategoryAcademicBrl.Insert(categoryAcademic, objContex);

            CategoryAcademic categoryAcademicGet = CategoryAcademicBrl.Get(1, objContex);
            categoryAcademicGet.Name = "UnitTestNameUpdate";
            categoryAcademicGet.Description = "UnitTestDescriptionUpdate";
            CategoryAcademicBrl.Update(objContex);

            CategoryAcademicBrl.Delete(1, objContex);
        } 
    }
}
