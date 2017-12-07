using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsDal
{
    public class ImageListDal
    {
        #region metodo
        /// <summary>
        /// Method for make a list from all table
        /// </summary>
        /// <param name="objContex"></param>
        /// <returns>list from table ImageEnter</returns>
        public static List<ImageEnter> Get(ModelUnibookContainer objContex)
        {
            List<ImageEnter> imageReturn = null;


            try
            {
                imageReturn = (from image in objContex.ImageEnter
                               where image.Deleted == false
                               select image).ToList<ImageEnter>();
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

            return imageReturn;

        }
        #endregion
    }
}
