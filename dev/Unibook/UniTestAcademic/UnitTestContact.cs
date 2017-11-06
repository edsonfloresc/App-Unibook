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
    /// Descripción resumida de UnitTestContact
    /// </summary>
    [TestClass]
    public class UnitTestContact
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            ModelUnibookContainer objContex = new ModelUnibookContainer();
            ContactDto contactDto = new ContactDto();
            contactDto.Data = "Data 1";
            contactDto.Description = "Descripcion 1";
            contactDto.Deleted = false;
            contactDto.Person = PersonBrl.GetDto(1, objContex);
            ContactBrl.Insert(contactDto, objContex);

            ContactDto contactGet = ContactBrl.GetDto(1, objContex);
            contactGet.Data = "Data 1 modificado";
            contactGet.Description = "Descripcion 1 modificado";
            ContactBrl.Update(contactGet,objContex);

            ContactBrl.Delete(1, objContex);
        }

        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferenceContact.WebContactServicesSoapClient soap = new ServiceReferenceContact.WebContactServicesSoapClient();
            ServiceReferenceContact.ContactDto contactDto = new ServiceReferenceContact.ContactDto();

            contactDto.Data = "Esta es un servicio";
            contactDto.Description = "Descripcion servicio";
            contactDto.Deleted = false;
            //contactDto.Person = PersonBrl.GetDto(1, objContex);
            soap.Insert(contactDto);

            ServiceReferenceContact.ContactDto contactGetDto = soap.Get(3);
            contactGetDto.Data = "Mdoficiado esto";
            contactGetDto.Description = "Vendo libro modificado de nuevo servicio modificado";
            soap.Update(contactDto);

            soap.Delete(2);

            ServiceReferenceContactList.WebContactListServicesSoapClient soap2 = new ServiceReferenceContactList.WebContactListServicesSoapClient();
            ServiceReferenceContactList.ContactDto[] contactList = soap2.Get();
        }
    }
}
