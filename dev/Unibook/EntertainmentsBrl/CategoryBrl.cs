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
    public class CategoryBrl
    {
        #region metodos
        /// <summary>
        /// Method for Get Category like object
        /// </summary>
        /// <param name="id">id from Category Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a Category Object</returns>
        public static CategoryEnterDto GetDto(int id, ModelUnibookContainer objContex)
        {

            CategoryEnterDto categoryDto = null;
            try
            {

                CategoryEnter category = CategoryDal.Get(id, objContex);
                categoryDto = new CategoryEnterDto();
                categoryDto.CategoryId = category.CategoryId;
                categoryDto.Description = category.Description;
                categoryDto.Deleted = category.Deleted;

            }

            catch (Exception)
            {
                return null;
            }

            return categoryDto;
        }

        public static CategoryEnter Get(int id, ModelUnibookContainer objContex)
        {

            CategoryEnter category = null;
            try
            {

                category = CategoryDal.Get(id, objContex);


            }

            catch (Exception)
            {
                return null;
            }

            return category;
        }

        /// <summary>
        /// Method for insert a new Category 
        /// </summary>
        /// <param name="entertainment"> object from class Category for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(CategoryEnterDto categoryDto, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryEnter category = new CategoryEnter();
                category.CategoryId = categoryDto.CategoryId;
                category.Description = categoryDto.Description;
                category.Deleted = categoryDto.Deleted;
                CategoryDal.Insert(category, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Method for Update Category
        /// </summary>
        /// <param name="entertainment">Object to update</param>
        /// <param name="objContex"></param>
        public static void Update(CategoryEnterDto categoryDto, ModelUnibookContainer objContex)
        {
            try
            {
                //CategoryDal.Update(objContex);
                CategoryEnter category = CategoryBrl.Get(categoryDto.CategoryId, objContex);
                category.Description = categoryDto.Description;
                category.Deleted = categoryDto.Deleted;
                CategoryDal.Update(objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from Category for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryDal.Delete(id, objContex);
            }

            catch (Exception)
            {

            }
        }
        #endregion
    }
}