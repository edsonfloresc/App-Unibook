using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class PersonDal
    {
        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns></returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person personReturn = null;


            try
            {
                personReturn = (from person in objContex.Person
                              where person.PersonId == id
                              select person).Single<Person>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }

            return personReturn;
        }

        /// <summary>
        /// Insert a person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Insert(Person person, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.Person.Add(person);
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Update(Person person, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
    }
}
