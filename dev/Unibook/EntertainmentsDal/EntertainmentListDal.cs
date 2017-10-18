using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsDal
{
    public class EntertainmentListDal
    {
        #region metodo
        /// <summary>
        /// Method for make a list from all table
        /// </summary>
        /// <param name="objContex"></param>
        /// <returns>list from table Entertainment</returns>
        public static List<Entertainment> Get(ModelUnibookContainer objContex)
        {
            List<Entertainment> EntertainmentsReturn = null;


            try
            {
                EntertainmentsReturn = (from entertainment in objContex.Entertainment
                                        where entertainment.Deleted == false
                                        select entertainment).ToList<Entertainment>();
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

            return EntertainmentsReturn;

        }
        #endregion
    }
}
