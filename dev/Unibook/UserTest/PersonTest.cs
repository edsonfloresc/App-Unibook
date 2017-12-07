using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.UserTest
{
    [TestClass]
    public class PersonTest
    {
        ModelUnibookContainer container = new ModelUnibookContainer();

        [TestMethod]
        public void TestCreatUser()
        {
            Person person = new Person();
            person.Name = "Rodrigo";
            person.LastName = "Siles Mayorga";
            person.Gender = GenderBrl.Get(1, container);
<<<<<<< HEAD
            person.Birthday = DateTime.Now;
=======
            //person.Birthday = DateTime.Now;
>>>>>>> master
            //PersonBrl.Insertar(person, container);
        }

        [TestMethod]
        public void TestUpdatetUser()
        {
            Person person = PersonBrl.Get(2, container);
            person.Name = "Maria";
            //PersonBrl.Update(person, container);
        }
    }
}
