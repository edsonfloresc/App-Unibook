using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UniTestAcademic
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
            PublicationAcademicDto publicationAcademicDto = new PublicationAcademicDto() { Description = "Descripcion 1",Image = "Imagen 1", DatePublication = DateTime.Now, Deleted = false };           
            publicationAcademicDto.CategoryAcademic = CategoryAcademicBrl.GetDto(1, objContex);
            publicationAcademicDto.User = UserBrl.GetDto(1, objContex);
            PublicationAcademicBrl.Insert(publicationAcademicDto, objContex);

            PublicationAcademicDto publicationAcademicGet = PublicationAcademicBrl.GetDto(1, objContex);
            publicationAcademicGet.Description = "Descripcion 1 modificado";
            publicationAcademicGet.Image = "Imagen 1 modificado";
            publicationAcademicGet.DatePublication = DateTime.Now;
            PublicationAcademicBrl.Update(publicationAcademicGet,objContex);

            PublicationAcademicBrl.Delete(1, objContex);

            List<PublicationAcademicDto> publicationList = PublicationAcademicListBrl.Get(objContex);
        }

        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferencePublicationAcademic.WebPublicationAcademicServicesSoapClient soap = new ServiceReferencePublicationAcademic.WebPublicationAcademicServicesSoapClient();
            ServiceReferencePublicationAcademic.PublicationAcademicDto publicationAcademicDto = new ServiceReferencePublicationAcademic.PublicationAcademicDto() { Description = "Descripcion 1", Image = "Imagen 1", DatePublication = DateTime.Now, Deleted = false };

            ServiceReferenceCategoryAcademic.WebCategoryAcademicServicesSoapClient soapCategory = new ServiceReferenceCategoryAcademic.WebCategoryAcademicServicesSoapClient();
            //publicationAcademicDto.CategoryAcademic =  soapCategory.Get(1);
            //publicationAcademicDto.User = UserBrl.GetDto(1, objContex);       
            soap.Insert(publicationAcademicDto);

            ServiceReferencePublicationAcademic.PublicationAcademicDto publicationAcademicGetDto = soap.Get(3);
            publicationAcademicGetDto.Description = "Descripcion 1 modificado";
            publicationAcademicGetDto.Image = "Imagen 1 modificado";
            publicationAcademicGetDto.DatePublication = DateTime.Now;
            soap.Update(publicationAcademicGetDto);

            soap.Delete(7);

            ServiceReferencePublicationAcademicList.WebPublicationAcademicListServicesSoapClient soap2 = new ServiceReferencePublicationAcademicList.WebPublicationAcademicListServicesSoapClient();
            ServiceReferencePublicationAcademicList.PublicationAcademicDto[] publicationList = soap2.Get();
        }
    }
}
