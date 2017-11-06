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
    /// Descripción resumida de UnitTestSubject
    /// </summary>
    [TestClass]
    public class UnitTestSubject
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            SubjectDto subjectDto = new SubjectDto();
            subjectDto.Name = "Fisica";
            subjectDto.Description = "Materia de fisica";
            subjectDto.Deleted = false;          
            SubjectBrl.Insert(subjectDto, objContex);

            SubjectDto subjectGet = SubjectBrl.GetDto(1, objContex);
            subjectGet.Name = "Nombre 1 modificado";
            subjectGet.Description = "Descripcion 1 modificado";
            SubjectBrl.Update(subjectDto,objContex);

            SubjectBrl.Delete(1, objContex);

            List<SubjectDto> subjectList = SubjectListBrl.Get(objContex); 
        }

        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferenceSubject.WebSubjectServicesSoapClient soap = new ServiceReferenceSubject.WebSubjectServicesSoapClient();
            ServiceReferenceSubject.SubjectDto subjectDto = new ServiceReferenceSubject.SubjectDto();
            subjectDto.Name = "Fisica";
            subjectDto.Description = "Materia de fisica";
            subjectDto.Deleted = false; 
            soap.Insert(subjectDto);

            ServiceReferenceSubject.SubjectDto subjectGetDto = soap.Get(3);
            subjectGetDto.Name = "Nombre 1 modificado";
            subjectGetDto.Description = "Descripcion 1 modificado";
            soap.Update(subjectDto);

            soap.Delete(7);

            ServiceReferenceSubjectList.WebSubjectListServicesSoapClient soap2 = new ServiceReferenceSubjectList.WebSubjectListServicesSoapClient();
            ServiceReferenceSubjectList.SubjectDto[] subjectList = soap2.Get();
        }
    }
}
