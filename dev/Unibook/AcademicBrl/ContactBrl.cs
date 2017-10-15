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
    public class ContactBrl
    {
        #region Methods

        /// <summary>
        /// Insert a contact
        /// </summary>
        /// <param name="contact">Object contact to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(Contact contact, ModelUnibookContainer objContex)
        {
            try
            {
                ContactDal.Insert(contact, objContex);
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
        /// Get contact by id
        /// </summary>
        /// <param name="id">Id contact to search</param>
        /// <returns>Return object contact</returns>
        public static Contact Get(int id, ModelUnibookContainer objContex)
        {
            Contact contact = null;

            try
            {
                contact = ContactDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contact;
        }

        /// <summary>
        /// Update a contact 
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                ContactDal.Update(objContex);
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
        /// Deleted a contact
        /// </summary>
        /// <param name="id">Id contact to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                ContactDal.Delete(id, objContex);
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
