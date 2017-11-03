using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.PeopleDal;

namespace Univalle.Fie.Sistemas.UniBook.PeopleBrl
{
    public class PersonTypeBrl
    {
        public static PersonType Get(byte id, ModelPeopleAppContainer objContex)
        {
            PersonType personType = null;
            try
            {
                personType = PersonTypeDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personType;
        }

     
    }
}
