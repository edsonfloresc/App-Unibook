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
    public class GenderBrl
    {

        /// <summary>
        /// Get a gender with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Gender Get(int id, ModelUnibookContainer objContex)
        {
            Gender gender = null;
            try
            {
                gender = GenderDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return gender;
        }

        /// <summary>
        /// Get a gender with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static GenderDto GetDto(int id, ModelUnibookContainer objContex)
        {
            GenderDto genderDto = null;
            try
            {
                Gender gender = GenderDal.Get(id, objContex);
                genderDto = new GenderDto();
                genderDto.GenderId = gender.GenderId;
                genderDto.Name = gender.Name;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return genderDto;
        }
    }
}
