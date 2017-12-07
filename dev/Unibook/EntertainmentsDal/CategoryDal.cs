using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsDal
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
        public static CategoryEnter Get(int id, ModelUnibookContainer objContex)
        {
            CategoryEnter categoryReturn = null;


            try
            {
                categoryReturn = (from category in objContex.CategoryEnter
                                  where category.Deleted == false && category.CategoryId == id
                                  select category).Single<CategoryEnter>();


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

            return categoryReturn;
        }

        /// <summary>
        /// Method for insert a new Category 
        /// </summary>
        /// <param name="category"> object from class Category for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(CategoryEnter category, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CategoryEnter.Add(category);
                objContex.SaveChanges();
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
        }


        /// <summary>
        /// Method for Update Category
        /// </summary>
        /// <param name="category">Object to update</param>
        /// <param name="objContex"></param>
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
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
                CategoryEnter category = objContex.CategoryEnter.Find(id);
                category.Deleted = true;
                objContex.SaveChanges();
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
        }
        #endregion
    }
}
