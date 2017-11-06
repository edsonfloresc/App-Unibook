using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class PersonDal
    {
        #region Methods

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns>Return object person</returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person personReturn = null;
      
            try
            {
                bool exist = (from person in objContex.PersonSet
                              where person.Deleted == false && person.PersonId == id
                              select person).Count() > 0;
                if (exist)
                {
                    personReturn = (from person in objContex.PersonSet
                                    where person.Deleted == false && person.PersonId == id
                                    select person).Single<Person>();
                }
             
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

            return personReturn;
        }

        /// <summary>
        /// Insert a person
        /// </summary>
        /// <param name="person">Object person to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(Person person, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.PersonSet.Add(person);
                objContex.SaveChanges();
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
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a person
        /// </summary>
        /// <param name="id">Id person to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                Person person = objContex.PersonSet.Find(id);
                person.Deleted = true;
                objContex.SaveChanges();
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
        }

        #endregion
    }
}
