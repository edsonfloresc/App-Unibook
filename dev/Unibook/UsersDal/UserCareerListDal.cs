using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class UserCareerListDal
    {
        /// <summary>
        /// Get list userCareer
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<UserCareer> Get(ModelUnibookContainer objContex)
        {
            List<UserCareer> userCareerReturn = null;

            try
            {
                userCareerReturn = (from user in objContex.UserCareer
                                 select user).ToList<UserCareer>();
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

            return userCareerReturn;
        }
    }
}
