using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.PeopleDal
{
    public class PersonTypeDal
    {
        public static PersonType Get(byte id, ModelPeopleAppContainer objContex)
        {
            PersonType personReturn = null;


            try
            {
                bool exist = (from personType in objContex.PersonTypeSet
                              where personType.Id == id
                              select personType).Count() > 0;
                if (exist)
                {
                    personReturn = (from personType in objContex.PersonTypeSet
                                    where personType.Id == id
                                    select personType).Single<PersonType>();
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

            return personReturn;
        }
    }
}
