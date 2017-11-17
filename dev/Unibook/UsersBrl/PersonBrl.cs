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
    public class PersonBrl
    {
        #region Methods

        /// <summary>
        /// Insert a person
        /// </summary>
        /// <param name="person">Object person to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PersonDto personDto, ModelUnibookContainer objContex)
        {
            try
            {
                Person person = new Person();
                person.PersonId = personDto.PersonId;
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.BirthDay;
                person.Deleted = personDto.Deleted;
                //person.Gender = GenderBrl.Get(personDto.Gender.GenderId);
                person.User = UserBrl.Get(person.User.UserId, objContex);
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
        /// Get person by id Dto
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns>Return object person</returns>
        public static PersonDto GetDto(long id, ModelUnibookContainer objContex)
        {
            PersonDto personDto = null;

            try
            {
                Person person = PersonDal.Get(id, objContex);
                personDto = new PersonDto();
                personDto.PersonId = person.PersonId;
                personDto.Name = person.Name;
                personDto.LastName = person.LastName;
                personDto.BirthDay = person.Birthday;
                personDto.Deleted = person.Deleted;
                personDto.Gender = GenderBrl.GetDto(person.Gender.GenderId, objContex);
                personDto.User = UserBrl.GetDto(person.User.UserId, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personDto;
        }

        /// <summary>
        /// Update a Person
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        public static void Update(PersonDto personDto, ModelUnibookContainer objContex)
        {
            try
            {
                Person person = PersonDal.Get(personDto.PersonId, objContex);
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.BirthDay;
                person.Deleted = personDto.Deleted;
                //person.Gender = GenderBrl.Get(personDto.Gender.GenderId, objContex);
                person.User = UserBrl.Get(personDto.PersonId, objContex);
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
