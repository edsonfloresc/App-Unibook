using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace ForumDal
{
    public class CategoryDal
    {
        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="id">Id gender to search</param>
        /// <returns></returns>
        public static Category Get(short id, ModelUnibookContainer objContex)
        {
            Category categoryReturn = null;

            try
            {
                categoryReturn = (from category in objContex.Category
                                where category.CategoryId == id
                                select category).Single<Category>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                categoryReturn = null;
            }

            return categoryReturn;
        }

        /// <summary>
        /// Insert a category
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(Category category, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.Category.Add(category);
                objContex.SaveChanges();
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
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(Category category, ModelUnibookContainer objContex)
        {
            try
            {
                objContex.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write(string.Format("{0} {1} Error: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), ex.Message));
                throw ex;
            }
        }
    }
}
