using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.UniTestAcademic
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
            CommentAcademicDto commentAcademicDto = new CommentAcademicDto();
            commentAcademicDto.Description = "Esta es una mala publicacion";
            commentAcademicDto.DateComment = DateTime.Now;
            commentAcademicDto.Deleted = false;
            commentAcademicDto.PublicationAcademic = PublicationAcademicBrl.GetDto(1, objContex);
            commentAcademicDto.User = UserBrl.GetDto(1, objContex);
            CommentAcademicBrl.Insert(commentAcademicDto, objContex);

            CommentAcademicDto commentAcademicGet = CommentAcademicBrl.GetDto(3, objContex);
            commentAcademicGet.Description = "Vendo libro modificado de nuevo";
            commentAcademicGet.DateComment = DateTime.Now;
            CommentAcademicBrl.Update(commentAcademicGet,objContex);

            CommentAcademicBrl.Delete(1, objContex);

            List<CommentAcademicDto> commentList = CommentAcademicListBrl.Get(objContex);
        }
  
        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferenceCommentAcademic.WebCommentAcademicServicesSoapClient soap = new ServiceReferenceCommentAcademic.WebCommentAcademicServicesSoapClient();

            ServiceReferencePublicationAcademic.WebPublicationAcademicServicesSoapClient soapPublication = new ServiceReferencePublicationAcademic.WebPublicationAcademicServicesSoapClient();

            

            ServiceReferenceCommentAcademic.CommentAcademicDto commentAcademicDto = new ServiceReferenceCommentAcademic.CommentAcademicDto();
            commentAcademicDto.Description = "Esta es una mala publicacion de Servicio";
            commentAcademicDto.DateComment = DateTime.Now;
            //commentAcademicDto.PublicationAcademic = soapPublication.Get(1);
            //commentAcademicDto.User = UserBrl.GetDto(1);
            soap.Insert(commentAcademicDto);

            ServiceReferenceCommentAcademic.CommentAcademicDto commentAcademicGetDto = soap.Get(3);
            commentAcademicGetDto.Description = "Vendo libro modificado de nuevo servicio modificado";
            commentAcademicGetDto.DateComment = DateTime.Now;
            soap.Update(commentAcademicGetDto);

            soap.Delete(2);

            ServiceReferenceCommentAcademicList.WebCommentAcademicListServicesSoapClient soap2 = new ServiceReferenceCommentAcademicList.WebCommentAcademicListServicesSoapClient();
            ServiceReferenceCommentAcademicList.CommentAcademicDto[] commentList = soap2.Get();
        }               
    }
}
