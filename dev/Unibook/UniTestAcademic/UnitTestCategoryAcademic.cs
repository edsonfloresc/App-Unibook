using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.UniTestAcademic
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
            CategoryAcademicDto categoryAcademicDto = new CategoryAcademicDto();
            categoryAcademicDto.Name = "Nueva Pruebita SS";
            categoryAcademicDto.Description = "Descripcion Pruebita SS";
            categoryAcademicDto.Deleted = false;
            CategoryAcademicBrl.Insert(categoryAcademicDto, objContex);

            CategoryAcademicDto categoryAcademicGet = CategoryAcademicBrl.GetDto(1, objContex);
            categoryAcademicGet.Name = "Campeonanitito SS";
            categoryAcademicGet.Description = "Eventito estudiantil SS";
            CategoryAcademicBrl.Update(categoryAcademicGet,objContex);

            CategoryAcademicBrl.Delete(1, objContex);

            List<CategoryAcademicDto> categoryList = CategoryAcademicListBrl.Get(objContex); 
        }

        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferenceCategoryAcademic.WebCategoryAcademicServicesSoapClient soap = new ServiceReferenceCategoryAcademic.WebCategoryAcademicServicesSoapClient();
            ServiceReferenceCategoryAcademic.CategoryAcademicDto categoryAcademicDto = new ServiceReferenceCategoryAcademic.CategoryAcademicDto();
            categoryAcademicDto.Name = "Prueba Servicio Nueva";
            categoryAcademicDto.Description = "Descripcion Servicio Nueva";
            categoryAcademicDto.Deleted = false;
            soap.Insert(categoryAcademicDto);

            ServiceReferenceCategoryAcademic.CategoryAcademicDto categoryAcademicGetDto = soap.Get(3);
            categoryAcademicGetDto.Name = "Name update";
            categoryAcademicGetDto.Description = "Easdas";
            soap.Update(categoryAcademicGetDto);

            soap.Delete(7);

            ServiceReferenceCategoryAcademicList.WebCategoryAcademicListServicesSoapClient soap2 = new ServiceReferenceCategoryAcademicList.WebCategoryAcademicListServicesSoapClient();
            ServiceReferenceCategoryAcademicList.CategoryAcademicDto[] categoryList = soap2.Get();
        }

    }
}
