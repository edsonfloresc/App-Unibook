using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class GenderDal
    {
        /// <summary>
        /// Get gender by id
        /// </summary>
        /// <param name="id">Id gender to search</param>
        /// <returns></returns>
        public static Gender Get(int id, ModelUnibookContainer objContex)
        {
            Gender genderReturn = null;

            try
            {
                genderReturn = (from gender in objContex.GenderSet
                                where gender.GenderId == id
                                select gender).Single<Gender>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                genderReturn = null;
            }

            return genderReturn;
        }
    }
}
