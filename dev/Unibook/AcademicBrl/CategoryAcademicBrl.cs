using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class CategoryAcademicBrl
    {
        #region Methods

        /// <summary>
        /// Insert a category
        /// </summary>
        /// <param name="categoryAcademic">Object category to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(CategoryAcademic categoryAcademic, ModelUnibookContainer objContex)
        {
            try
            {
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
        /// Update a category
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
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
