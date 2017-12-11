using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace ForumDal
{
    public class CategoryListDal
    {
        /// <summary>
        /// Get list category
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<Category> Get(ModelUnibookContainer objContex)
        {
            List<Category> categorysReturn = null;

            try
            {
                categorysReturn = (from category in objContex.Category
                                 select category).ToList<Category>();
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

            return categorysReturn;
        }
    }
}
