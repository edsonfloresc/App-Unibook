using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class CategoryAcademicListBrl
    {
        /// <summary>
        /// Get list Category 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<CategoryAcademicDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<CategoryAcademicDto> categoryList = new List<CategoryAcademicDto>();
                foreach (var item in CategoryAcademicListDal.Get(objContex))
                {
                    categoryList.Add(CategoryAcademicBrl.GetDto(item.CategoryAcademicId,objContex));
                }

                return categoryList;
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
