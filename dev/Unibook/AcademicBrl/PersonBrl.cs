using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class PersonBrl
    {
        #region Methods

        /// <summary>
        /// Insert a person
        /// </summary>
        /// <param name="person">Object person to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(Person person, ModelUnibookContainer objContex)
        {
            try
            {
                PersonDal.Insert(person, objContex);
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
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns>Return object person</returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person person = null;

            try
            {
                person = PersonDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        /// <summary>
        /// Update a Person
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                PersonDal.Update(objContex);
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
        /// Deleted a person
        /// </summary>
        /// <param name="id">Id person to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                PersonDal.Delete(id, objContex);
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
        #endregion
    }
}
