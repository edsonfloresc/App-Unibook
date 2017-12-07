using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Data.Entity.Validation;
>>>>>>> master
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class PersonDal
    {
<<<<<<< HEAD
=======
        #region Methods

>>>>>>> master
        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
<<<<<<< HEAD
        /// <returns></returns>
=======
        /// <returns>Return object person</returns>
>>>>>>> master
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person personReturn = null;

<<<<<<< HEAD

            try
            {
                personReturn = (from person in objContex.Person
                              where person.PersonId == id
                              select person).Single<Person>();
=======
            try
            {
                bool exist = (from person in objContex.Person
                              where person.PersonId == id
                              select person).Count() > 0;
                if (exist)
                {
                    personReturn = (from person in objContex.Person
                                    where person.PersonId == id
                                    select person).Single<Person>();
                }

            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
>>>>>>> master
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
<<<<<<< HEAD
        /// <param name="person"></param>
        /// <param name="objContex"></param>
=======
        /// <param name="person">Object person to insert</param>
        /// <param name="objContex">Get table to object</param>
>>>>>>> master
        public static void Insert(Person person, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.Person.Add(person);
                objContex.SaveChanges();
            }
<<<<<<< HEAD
=======
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
        }

        /// <summary>
        /// Update a Person
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
>>>>>>> master
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
<<<<<<< HEAD
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
=======
        /// Deleted a person
        /// </summary>
        /// <param name="id">Id person to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                Person person = objContex.Person.Find(id);
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
>>>>>>> master
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
<<<<<<< HEAD
=======

        #endregion
>>>>>>> master
    }
}
