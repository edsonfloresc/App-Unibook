using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleBrl;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPerson
    {
        [TestMethod]
        public void TestMethodBrl()
        {
            //Test Brl
            Person person = new Person() { FirstName = "Roger", Deleted = false, LastName = "Aguilar" };
            PeopleContainer context = new PeopleContainer();
            PersonBrl.Insertar(person, context);


            PersonBrl.Update(context);

            PersonBrl.Delete(1, context);


        }

        [TestMethod]
        public void TestMethodServices()
        {
            ServiceReferencePeople.WebPersonServiceSoapClient soap = new ServiceReferencePeople.WebPersonServiceSoapClient();
            ServiceReferencePeople.Person person = new ServiceReferencePeople.Person() { FirstName = "Juan", LastName = "Peres" };
            soap.Insert(person);

            ServiceReferencePeople.Person person1 = soap.Get(1);
            person1.FirstName = "Pedro";
            soap.Update(person1);

            soap.Delete(1);

            ServiceReferencePeopleList.WebPersonsListServicesSoapClient soa1 = new ServiceReferencePeopleList.WebPersonsListServicesSoapClient();
            ServiceReferencePeopleList.Person[] personas = soa1.Get();


        }
    }
}
