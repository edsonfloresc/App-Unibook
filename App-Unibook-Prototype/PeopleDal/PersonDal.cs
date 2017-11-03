using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;


namespace Univalle.Fie.Sistemas.UniBook.PeopleDal
{
    /// <summary>
    /// Person data access layer
    /// </summary>
    public class PersonDal
    {
        #region metodos

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns></returns>
       public static Person Get(Guid id, ModelPeopleAppContainer objContex)
        {
            Person personReturn = null;


            try
            {
                bool exist = (from person in objContex.PersonSet
                              where person.Deleted == false && person.Id == id
                              select person).Count() > 0;
                if (exist)
                {
                    personReturn = (from person in objContex.PersonSet
                                    where person.Deleted == false && person.Id == id
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
        /// Insert a Person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Insert(Person person, ModelPeopleAppContainer objContex)
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
        /// Inserta un  Person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Update(ModelPeopleAppContainer objContex)
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
        /// Elimina un Codigo QR
        /// </summary>
        /// <param name="qr"></param>
        /// <param name="objContex"></param>
        public static void Delete(Guid id, ModelPeopleAppContainer objContex)
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

        #endregion metodos
    }
}
