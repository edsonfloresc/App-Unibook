using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.UsersDal
{
    public class CategoryDal
    {

        #region metodos
        /// <summary>
        /// Method for Get Category like object
        /// </summary>
        /// <param name="id">id from Category Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a Category Object</returns>
        public static Category Get(int id, ModelUnibookContainer objContex)
        {
            Category categoryReturn = null;


            try
            {
                categoryReturn = (from category in objContex.CategorySet
                                  where category.Deleted == false && category.CategoryId == id
                                  select category).Single<Category>();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryReturn;
        }

        /// <summary>
        /// Method for insert a new Category 
        /// </summary>
        /// <param name="entertainment"> object from class Category for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(Category category, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CategorySet.Add(category);
                objContex.SaveChanges();
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
        /// Method for Update Category
        /// </summary>
        /// <param name="entertainment">Object to update</param>
        /// <param name="objContex"></param>
        public static void Update(Category category, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
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
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from Category for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                Category category = objContex.CategorySet.Find(id);
                category.Deleted = true;
                objContex.SaveChanges();
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
