using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class PersonBrl
    {
        /// <summary>
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Person Get(long id, ModelUnibookContainer objContex)
        {
            try
            {
                return PersonDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

        /// <summary>
        /// Create a new person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Insertar(Person person, ModelUnibookContainer objContex)
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
        /// Update changes in the context
        /// </summary>
        /// <param name="person"></param>
        /// <param name="objContex"></param>
        public static void Update(Person person, ModelUnibookContainer objContex)
        {
            try
            {
                PersonDal.Update(person, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
