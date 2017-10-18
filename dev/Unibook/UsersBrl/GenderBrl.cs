using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
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
            try
            {
                return GenderDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
