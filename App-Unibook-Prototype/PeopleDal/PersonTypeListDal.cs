using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.PeopleDal
{
    public class PersonTypeListDal
    {
        /// <summary>
        /// Get list of person type
        /// </summary>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static List<PersonType> Get(ModelPeopleAppContainer objContex)
        {
            List<PersonType> personTypeReturn = null;


            try
            {
                personTypeReturn = (from personType in objContex.PersonTypeSet
                                 select personType).ToList<PersonType>();
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

            return personTypeReturn;

        }
    }
}
