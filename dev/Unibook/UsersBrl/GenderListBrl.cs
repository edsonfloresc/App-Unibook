using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class GenderListBrl
    {
        /// <summary>
        /// Get list gender 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<GenderDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<GenderDto> genderList = new List<GenderDto>();
                foreach (var item in GenderListDal.Get(objContex))
                {
                    GenderDto gender = new GenderDto()
                    {
                        Name = item.Name,
                        GenderId = item.GenderId,
                    };

                    genderList.Add(gender);
                }

                return genderList;
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
