using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleBrl;

namespace ConsoleAppPruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Roger", Deleted = false, FirstName = "Aguilar" };
            PeopleContainer context = new PeopleContainer();
            PersonBrl.Insertar(person, context);

            Person person1 = PersonBrl.Get(1, context);
            person1.Name = "Pedro";
            PersonBrl.Update(context);

            PersonBrl.Delete(1, context);
        }
    }
}
