using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWebTestPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insert

            //ServiceReferencePerson.WebPersonServiceSoapClient client = new ServiceReferencePerson.WebPersonServiceSoapClient();
            // ServiceReferencePerson.PersonDto getPersonDto = client.Get(new Guid("fb7275e7-0e73-49cd-8bef-6676efc6a7d9"));

            /* ServiceReferencePerson.PersonDto personDto = new ServiceReferencePerson.PersonDto();
               personDto.Deleted = false;
               personDto.FirstName = "Laura";
               personDto.LastName = "Perez";
               personDto.Id = Guid.NewGuid();
               personDto.PersonType = new ServiceReferencePerson.PersonTypeDto();
               personDto.PersonType.Id = 2;
             client.Insert(personDto);*/


            //Update
            /*getPersonDto.LastName = "Pedro";
            getPersonDto.PersonType.Id = 2;
            client.Update(getPersonDto);*/

            //Get
            // WebPersonServices.PersonDto getPersonDto = client.Get(personDto.Id);

            //Delete
            // client.Delete(new Guid("7bd01b33-9a3f-4593-b402-96c0fcc608ee"));

            ServiceReferencePersonList.WebPersonListServiceSoapClient clientSoap = new ServiceReferencePersonList.WebPersonListServiceSoapClient();
            ServiceReferencePersonList.PersonDto[] personList = clientSoap.Get();

        }
    }
}
