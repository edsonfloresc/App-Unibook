using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class ContactBrl
    {
        #region Methods

        /// <summary>
        /// Insert a contact
        /// </summary>
        /// <param name="contact">Object contact to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(ContactDto contactDto, ModelUnibookContainer objContex)
        {
            try
            {
                Contact contact = new Contact();
                contact.ContactId = contactDto.ContactId;
                contact.Data = contactDto.Data;
                contact.Description = contactDto.Description;
                contact.Person = PersonBrl.Get(contactDto.Person.PersonId, objContex);
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
        /// Get contact by id Dto
        /// </summary>
        /// <param name="id">Id contact to search</param>
        /// <returns>Return object contact</returns>
        public static ContactDto GetDto(int id, ModelUnibookContainer objContex)
        {
            ContactDto contactDto = null;

            try
            {
                Contact contact = Get(id, objContex);
                contactDto = new ContactDto();
                contactDto.ContactId = contact.ContactId;
                contactDto.Data = contact.Data;
                contactDto.Description = contact.Description;
                contactDto.Deleted = contact.Deleted;
                contactDto.Person = PersonBrl.GetDto(contact.Person.PersonId, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contactDto;
        }

        /// <summary>
        /// Update a contact 
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ContactDto contactDto, ModelUnibookContainer objContex)
        {
            try
            {
                Contact contact = ContactDal.Get(contactDto.ContactId, objContex);
                contact.Data = contactDto.Data;
                contact.Description = contactDto.Description;
                contact.Deleted = contactDto.Deleted;
                contact.Person = PersonBrl.Get(contactDto.Person.PersonId, objContex);
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
