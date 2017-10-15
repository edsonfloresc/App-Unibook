using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace AcademicTest
{
    class PersonTest
    {
        static void MainPerson(string[] args)
        {
            Person person = new Person() { Name = "NameTest", LastName = "LastNameTest",BirthDay=DateTime.Now,Deleted = false};
            ModelUnibookContainer Objectcontext = new ModelUnibookContainer();
            PersonBrl.Insert(person, Objectcontext);

            Person personGet = PersonBrl.Get(1, Objectcontext);
            personGet.Name = "PruebaTestUpdate";
            PersonBrl.Update(Objectcontext);

            PersonBrl.Delete(1, Objectcontext);
        }
    }
}
