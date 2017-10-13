using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.PeopleDal
{
    public class PersonsListDal
    {
        public static List<Person> Get(PeopleContainer objContex)
        {
            List<Person> personsReturn = null;


            try
            {
                personsReturn = (from person in objContex.PersonSet
                                where person.Deleted == false 
                                select person).ToList<Person>();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return personsReturn;

        }
    }
}
