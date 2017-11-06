using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class PersonListBrl
    {
        /// <summary>
        /// Get list person 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<PersonDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<PersonDto> personList = new List<PersonDto>();
                foreach (var item in PersonListDal.Get(objContex))
                {
                    personList.Add(PersonBrl.GetDto(item.PersonId, objContex));
                }

                return personList;
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
