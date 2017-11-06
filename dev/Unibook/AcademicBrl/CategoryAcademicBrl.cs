using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class CategoryAcademicBrl
    {
        #region Methods

        /// <summary>
        /// Insert a category
        /// </summary>
        /// <param name="categoryAcademicDto">Object category to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(CategoryAcademicDto categoryAcademicDto, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryAcademic categoryAcademic = new CategoryAcademic();
                categoryAcademic.CategoryAcademicId = categoryAcademicDto.CategoryAcademicId;
                categoryAcademic.Name = categoryAcademicDto.Name;
                categoryAcademic.Description = categoryAcademicDto.Description;
                categoryAcademic.Deleted = categoryAcademicDto.Deleted;
                CategoryAcademicDal.Insert(categoryAcademic, objContex);
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

        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="id">Id category to search</param>
        /// <returns>Return object category</returns>
        public static CategoryAcademic Get(int id, ModelUnibookContainer objContex)
        {
            CategoryAcademic categoryAcademic = null;

            try
            {
                categoryAcademic = CategoryAcademicDal.Get(id, objContex);
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryAcademic;
        }

        /// <summary>
        /// Get category by id Dto
        /// </summary>
        /// <param name="id">Id category to search</param>
        /// <returns>Return object category</returns>
        public static CategoryAcademicDto GetDto(int id, ModelUnibookContainer objContex)
        {
            CategoryAcademicDto categoryAcademicDto = null;

            try
            {
                CategoryAcademic categoryAcademic = CategoryAcademicDal.Get(id, objContex);
                categoryAcademicDto = new CategoryAcademicDto();
                categoryAcademicDto.CategoryAcademicId = categoryAcademic.CategoryAcademicId;
                categoryAcademicDto.Name = categoryAcademic.Name;
                categoryAcademicDto.Description = categoryAcademic.Description;
                categoryAcademicDto.Deleted = categoryAcademic.Deleted;
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryAcademicDto; 
        }

        /// <summary>
        /// Update a category
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        /// <param name="categoryAcademicDto">Object with new data</param>
        public static void Update(CategoryAcademicDto categoryAcademicDto, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryAcademic categoryAcademic = CategoryAcademicBrl.Get(categoryAcademicDto.CategoryAcademicId, objContex);
                categoryAcademic.Name = categoryAcademicDto.Name;
                categoryAcademic.Description = categoryAcademicDto.Description;
                categoryAcademic.Deleted = categoryAcademicDto.Deleted;
                CategoryAcademicDal.Update(objContex);
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

        /// <summary>
        /// Deleted a category 
        /// </summary>
        /// <param name="id">Id category to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryAcademicDal.Delete(id, objContex);
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
