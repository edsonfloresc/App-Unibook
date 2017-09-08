using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleBrl;

namespace UnitTestProjectPerson
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person() { Name = "Juan", Deleted = false, FirstName = "Perez" };
            PeopleContainer context = new PeopleContainer();
            PersonBrl.Insertar(person, context);
        }
    }
}
