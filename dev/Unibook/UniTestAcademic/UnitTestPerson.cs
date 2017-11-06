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
    /// Descripción resumida de UnitTestPerson
    /// </summary>
    [TestClass]
    public class UnitTestPerson
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            PersonDto personDto = new PersonDto() { Name = "Nombre 1", LastName = "Apellido 1", BirthDay = DateTime.Now, Deleted = false };
            personDto.Name = "Royer";
            personDto.LastName = "Arevalo";
            personDto.BirthDay = DateTime.Now;
            personDto.Deleted = false;
            personDto.Gender = GenderBrl.GetDto(1,objContex);
            personDto.User = UserBrl.GetDto(1,objContex);
            PersonBrl.Insert(personDto, objContex);

            PersonDto personGet = PersonBrl.GetDto(1, objContex);
            personGet.Name = "Nombre 1 modificado";
            personGet.LastName = "Apellido 1 modificado";
            personGet.BirthDay = DateTime.Now;
            PersonBrl.Update(personGet,objContex);

            PersonBrl.Delete(1, objContex);

            List<PersonDto> personList = PersonListBrl.Get(objContex);
        }

        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferencePerson.WebPersonServicesSoapClient soap = new ServiceReferencePerson.WebPersonServicesSoapClient();
            ServiceReferencePerson.PersonDto personDto = new ServiceReferencePerson.PersonDto();
            personDto.Name = "Prueba Servicio Nueva";
            personDto.LastName = "Apellido";
            personDto.BirthDay = DateTime.Now;
            personDto.Deleted = false;
            //personDto.User = UserBrl.GetDto(1);
            //personDto.Gender = GenderBrl.GetDto(1);        
            soap.Insert(personDto);

            ServiceReferencePerson.PersonDto personGetDto = soap.Get(3);
            personGetDto.Name = "Nombre 1 modificado";
            personGetDto.LastName = "Apellido 1 modificado";
            personGetDto.BirthDay = DateTime.Now;
            soap.Update(personDto);

            soap.Delete(7);

            ServiceReferencePersonList.WebPersonListServicesSoapClient soap2 = new ServiceReferencePersonList.WebPersonListServicesSoapClient();
            ServiceReferencePersonList.PersonDto[] personList = soap2.Get();
        }
    }
}
