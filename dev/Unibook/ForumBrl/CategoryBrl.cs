using ForumDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace ForumBrl
{
    public class CategoryBrl
    {
        /// <summary>
        /// Get a category with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Category Get(short id, ModelUnibookContainer objContex)
        {
            Category category = null;
            try
            {
                category = CategoryDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return category;
        }

        /// <summary>
        /// Get a category with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CategoryDto GetDto(short id, ModelUnibookContainer objContex)
        {
            CategoryDto categoryDto = null;
            try
            {
                Category category = CategoryDal.Get(id, objContex);
                categoryDto = new CategoryDto();
                categoryDto.CategoryId = category.CategoryId;
                categoryDto.Name = category.Name;
                categoryDto.Purpose = category.Purpose;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(CategoryDto categoryDto, ModelUnibookContainer objContex)
        {
            try
            {
                Category category = CategoryBrl.Get(categoryDto.CategoryId, objContex);
                category.Name = categoryDto.Name;
                category.Purpose = categoryDto.Purpose;
                CategoryDal.Update(category, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Create a new category
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(CategoryDto categoryDto, ModelUnibookContainer objContex)
        {
            try
            {
                Category category = new Category();
                category.Name = categoryDto.Name;
                category.Purpose = categoryDto.Purpose;
                CategoryDal.Insert(category, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
