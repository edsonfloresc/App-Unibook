using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleDal;

namespace Univalle.Fie.Sistemas.UniBook.PeopleBrl
{
    public class PersonBrl
    {
        public static void Insertar(Person person, PeopleContainer objContex)
        {
            PersonDal.Insertar(person, objContex);
        }
    }
}
