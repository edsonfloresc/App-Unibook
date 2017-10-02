using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.UsersDal;

namespace Univalle.Fie.Sistemas.Unibook.UsersBrl
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
        public static Category Get(int id, ModelUnibookContainer objContex)
        {

            try
            {
                return CategoryDal.Get(id,objContex);
            }
         
            catch (Exception )
            {
              
            }

            return null;
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
                CategoryDal.Insert(category,objContex);
            }
          
            catch (Exception )
            {
           
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
                CategoryDal.Update(category,objContex);
            }
          
            catch (Exception )
            {
            
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
                CategoryDal.Delete(id,objContex);
            }
        
            catch (Exception )
            {
              
            }
        }
        #endregion
    }
}
