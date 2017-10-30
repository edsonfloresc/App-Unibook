using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Create a new person
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insertar(PersonDto personDto, ModelUnibookContainer objContex)
        {
            try
            {
                Person person = new Person();
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.Birthday;
                person.PersonId = personDto.PersonId;
                PersonDal.Insert(person, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            Person person = null;
            try
            {
                person = PersonDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }

        /// <summary>
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static PersonDto GetDto(long id, ModelUnibookContainer objContex)
        {
            PersonDto personDto = null;
            try
            {
                Person person = PersonDal.Get(id, objContex);
                personDto = new PersonDto();
                person.Name = personDto.Name;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.Birthday;
                person.PersonId = personDto.PersonId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(PersonDto personDto, ModelUnibookContainer objContex)
        {
            try
            {
                Person person = PersonBrl.Get(personDto.PersonId, objContex); ;
                person.LastName = personDto.LastName;
                person.Birthday = personDto.Birthday;
                person.PersonId = personDto.PersonId;
                PersonDal.Update(person, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
