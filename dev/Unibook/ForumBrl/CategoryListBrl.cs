using ForumDal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace ForumBrl
{
    public class CategoryListBrl
    {
        /// <summary>
        /// Get list gender 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<CategoryDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<CategoryDto> categoryList = new List<CategoryDto>();
                foreach (var item in CategoryListDal.Get(objContex))
                {
                    CategoryDto gender = new CategoryDto()
                    {
                        Name = item.Name,
                        CategoryId = item.CategoryId,
                    };

                    categoryList.Add(gender);
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
