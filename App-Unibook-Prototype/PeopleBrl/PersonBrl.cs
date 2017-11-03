using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleDal;

namespace Univalle.Fie.Sistemas.UniBook.PeopleBrl
{
    public class PersonBrl
    {
        /// <summary>
        /// Create a new person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Insertar(Person person, ModelPeopleAppContainer objContex)
        {
            try
            {
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
        public static Person Get(Guid id, ModelPeopleAppContainer objContex)
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
        /// Update changes in the context
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(ModelPeopleAppContainer objContex)
        {
            try
            {
                PersonDal.Update(objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(Guid id, ModelPeopleAppContainer objContex)
        {
            try
            {
                PersonDal.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
