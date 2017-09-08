using System;
using System.Data.Entity.Validation;
using System.Linq;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.PeopleDal
{
    public class PersonDal
    {
        #region metodos

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns></returns>
        public static Person Obtener(int id, PeopleContainer objContex)
        {
            Person personReturn = null;


            try
            {
                personReturn = (from person in objContex.PersonSet
                            where person.Deleted == false && person.Id == id
                            select person).Single<Person>();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personReturn;
        }

        /// <summary>
        /// Insert a Person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Insertar(Person person, PeopleContainer objContex)
        {
            try
            {
                objContex.PersonSet.Add(person);
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// Inserta un  Person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Actualizar(PeopleContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// Elimina un Codigo QR
        /// </summary>
        /// <param name="qr"></param>
        /// <param name="objContex"></param>
        public static void Eliminar(int id, PeopleContainer objContex)
        {
            try
            {
                Person person = objContex.PersonSet.Find(id);
                person.Deleted = true;
                objContex.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion metodos
    }
}
