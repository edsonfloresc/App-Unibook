using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.PeopleBrl
{
    public class PersonListBrl
    {
        /// <summary>
        /// Get list person 
        /// </summary>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static List<Person> Get(ModelPeopleAppContainer objContex)
        {
            try
            {
                return PeopleDal.PersonsListDal.Get(objContex);
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
    }
}
