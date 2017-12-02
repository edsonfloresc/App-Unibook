using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.UniBook.UsersDal
{
    public class GenderListDal
    {
        /// <summary>
        /// Get list gender
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<Gender> Get(ModelUnibookContainer objContex)
        {
            List<Gender> gendersReturn = null;

            try
            {
                gendersReturn = (from user in objContex.Gender
                                 select user).ToList<Gender>();
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

            return gendersReturn;
        }
    }
}
