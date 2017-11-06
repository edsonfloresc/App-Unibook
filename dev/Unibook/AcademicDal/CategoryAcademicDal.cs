using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.Common;

namespace Univalle.Fie.Sistemas.UniBook.AcademicDal
{
    public class CategoryAcademicDal
    {
        #region Methods

        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="id">Id category to search</param>
        /// <param name="objContex">Get table to object</param>
        /// <returns>Return object category</returns>
        public static CategoryAcademic Get(int id, ModelUnibookContainer objContex)
        {
            CategoryAcademic categoryAcademicReturn = null;
       
            try
            {

                bool exist = (from cateogryAcademic in objContex.CategoryAcademicSet
                              where cateogryAcademic.Deleted == false && cateogryAcademic.CategoryAcademicId == id
                              select cateogryAcademic).Count() > 0;
                if (exist)
                {
                    categoryAcademicReturn = (from categoryAcademic in objContex.CategoryAcademicSet
                                              where categoryAcademic.Deleted == false && categoryAcademic.CategoryAcademicId == id
                                              select categoryAcademic).Single<CategoryAcademic>();
                }

                
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

            return categoryAcademicReturn;
        }

        /// <summary>
        /// Insert a category
        /// </summary>
        /// <param name="categoryAcademic">Object category to insert</param>
        /// <param name="objContex">Get table to object</param>
        public static void Insert(CategoryAcademic categoryAcademic, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.CategoryAcademicSet.Add(categoryAcademic);
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
        /// Update a category
        /// </summary>
        /// <param name="objContex">Get table to object</param> 
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
        /// Deleted a category 
        /// </summary>
        /// <param name="id">Id category to deleted</param>
        /// <param name="objContex">Get table to object</param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CategoryAcademic categoryAcademic = objContex.CategoryAcademicSet.Find(id);
                categoryAcademic.Deleted = true;
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
