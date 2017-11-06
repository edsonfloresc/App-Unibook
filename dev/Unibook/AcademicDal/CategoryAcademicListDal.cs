using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class CategoryAcademicListDal
    {
        /// <summary>
        /// Get list category
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<CategoryAcademic> Get(ModelUnibookContainer objContex)
        {
            List<CategoryAcademic> categoriesReturn = null;

            try
            {
                categoriesReturn = (from category in objContex.CategoryAcademicSet
                                 where category.Deleted == false
                                 select category).ToList<CategoryAcademic>();
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

            return categoriesReturn;
        }
    }
}
