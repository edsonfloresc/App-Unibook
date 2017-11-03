using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.PeopleBrl
{
    public class PersonTypeListBrl
    {
        public static List<PersonType> Get(ModelPeopleAppContainer objContex)
        {
            try
            {
                return PeopleDal.PersonTypeListDal.Get(objContex);
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

        public static List<PersonTypeDto> GetDto(ModelPeopleAppContainer objContex)
        {
            List<PersonTypeDto> listDto = new List<PersonTypeDto>();
            try
            {
                foreach (var item in PeopleDal.PersonTypeListDal.Get(objContex))
                {
                    listDto.Add(new PersonTypeDto() { Id = item.Id, Name = item.Name });
                } 
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listDto;
        }
    }
}
