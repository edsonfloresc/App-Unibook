using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class ContactDal
    {
        #region Methods

        /// <summary>
        /// Get contact by id
        /// </summary>
        /// <param name="id">Id contact to search</param>
        /// <returns>Return object contact</returns>
        public static Contact Get(int id, ModelUnibookContainer objContex)
        {
            Contact contactReturn = null;

            try
            {
                bool exist = (from contact in objContex.ContactSet
                              where contact.Deleted == false && contact.ContactId == id
                              select contact).Count() > 0;
                if (exist)
                {
                    contactReturn = (from contact in objContex.ContactSet
                                     where contact.Deleted == false && contact.ContactId == id
                                     select contact).Single<Contact>();
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

            return contactReturn;
        }

        /// <summary>
        /// Insert a contact
        /// </summary>
        /// <param name="contact">Object contact to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(Contact contact, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.ContactSet.Add(contact);
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
        /// Update a contact 
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
        /// Deleted a contact
        /// </summary>
        /// <param name="id">Id contact to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                Contact contact = objContex.ContactSet.Find(id);
                contact.Deleted = true;
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
