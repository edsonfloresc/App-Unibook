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
            Person person = new Person() { Name = "Juan", Deleted = false, FirstName = "Perez" };
            PeopleContainer context = new PeopleContainer();
            PersonBrl.Insertar(person, context);
        }
    }
}
