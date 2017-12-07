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
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class PersonBrl
    {
<<<<<<< HEAD
        /// <summary>
        /// Create a new person
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insertar(PersonDto personDto, ModelUnibookContainer objContex)
=======
        #region Methods

        /// <summary>
        /// Insert a person
        /// </summary>
        /// <param name="person">Object person to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(PersonDto personDto, ModelUnibookContainer objContex)
>>>>>>> master
        {
            try
            {
                Person person = new Person();
<<<<<<< HEAD
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.Birthday;
                person.PersonId = personDto.PersonId;
                PersonDal.Insert(person, objContex);
            }
=======
                person.PersonId = personDto.PersonId;
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.BirthDay;
                person.Deleted = personDto.Deleted;
                //person.Gender = GenderBrl.Get(personDto.Gender.GenderId);
                PersonDal.Insert(person, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
>>>>>>> master
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person person = null;
=======
        /// Get person by id
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns>Return object person</returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person person = null;

>>>>>>> master
            try
            {
                person = PersonDal.Get(id, objContex);
            }
<<<<<<< HEAD
=======
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
>>>>>>> master
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static PersonDto GetDto(long id, ModelUnibookContainer objContex)
        {
            PersonDto personDto = null;
=======
        /// Get person by id Dto
        /// </summary>
        /// <param name="id">Id person to search</param>
        /// <returns>Return object person</returns>
        public static PersonDto GetDto(long id, ModelUnibookContainer objContex)
        {
            PersonDto personDto = null;

>>>>>>> master
            try
            {
                Person person = PersonDal.Get(id, objContex);
                personDto = new PersonDto();
<<<<<<< HEAD
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.Birthday;
                person.PersonId = personDto.PersonId;
               
=======
                personDto.PersonId = person.PersonId;
                personDto.Name = person.Name;
                personDto.LastName = person.LastName;
                personDto.BirthDay = person.Birthday;
                personDto.Deleted = person.Deleted;
                personDto.Gender = GenderBrl.GetDto(person.Gender.GenderId, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
>>>>>>> master
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personDto;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
=======
        /// Update a Person
        /// </summary>
        /// <param name="objContex">Get table to object</param>
>>>>>>> master
        public static void Update(PersonDto personDto, ModelUnibookContainer objContex)
        {
            try
            {
<<<<<<< HEAD
                Person person = PersonBrl.Get(personDto.PersonId, objContex); ;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.Birthday;
                person.PersonId = personDto.PersonId;
                PersonDal.Update(person, objContex);
=======
                Person person = PersonDal.Get(personDto.PersonId, objContex);
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.BirthDay;
                person.Deleted = personDto.Deleted;
                //person.Gender = GenderBrl.Get(personDto.Gender.GenderId, objContex);
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
>>>>>>> master
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
<<<<<<< HEAD
=======
        #endregion
>>>>>>> master
    }
}
