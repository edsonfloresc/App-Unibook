using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsDal;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl
{
    public class CategoryListBrl
    {
        #region metodo
        public static List<CategoryEnterDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<CategoryEnterDto> categoryList = new List<CategoryEnterDto>();
                foreach (var item in CategoryListDal.Get(objContex))
                {
                    CategoryEnterDto category = new CategoryEnterDto()
                    {
                        Deleted = item.Deleted,
                        Description = item.Description,
                        CategoryId = item.CategoryId


                    };

                    categoryList.Add(category);
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
        #endregion
    }
}
