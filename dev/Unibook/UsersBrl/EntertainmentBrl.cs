using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.UsersDal;

namespace Univalle.Fie.Sistemas.Unibook.UsersBrl
{
    public class EntertainmentBrl
    {
        #region metodos
        /// <summary>
        /// Method for Get Entertainment like object
        /// </summary>
        /// <param name="id">id from Entertainment Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a Entertainment Object</returns>
        public static Entertainment Get(int id, ModelUnibookContainer objContex)
        {
           


            try
            {
               return EntertainmentDal.Get(id,objContex);
            }
         
            catch (Exception )
            {

            }

            return null;
        }

        /// <summary>
        /// Method for insert a new Entertainment without image
        /// </summary>
        /// <param name="entertainment"> object from class Entertainment for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(Entertainment entertainment, ModelUnibookContainer objContex)
        {
            try
            {
                EntertainmentDal.Insert(entertainment,objContex);
            }
            
            catch (Exception)
            {
         
            }
        }

        /// <summary>
        /// Method for insert a new Entertainment with image
        /// </summary>
        /// <param name="entertainment"> object from class Entertainment for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(Entertainment entertainment, ImageEnter image, ModelUnibookContainer objContex)
        {
            try
            {
                EntertainmentDal.Insert(entertainment, image, objContex);
            }
           
            catch (Exception )
            {
          
            }
        }

        /// <summary>
        /// Method for Update Entertainment
        /// </summary>
        /// <param name="entertainment">Object to update</param>
        /// <param name="objContex"></param>
        public static void Update( ModelUnibookContainer objContex)
        {
            try
            {
                EntertainmentDal.Update(objContex);
            }
        
            catch (Exception )
            {
             
            }
        }

        /// <summary>
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from Entertaiment for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                EntertainmentDal.Delete(id,objContex);
            }
        
            catch (Exception )
            {
           
            }
        }
        #endregion
    }
}
