using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.UsersDal
{
    public class EntertainmentDal
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
            Entertainment EntertainmentReturn = null;


            try
            {
                EntertainmentReturn = (from entertainment in objContex.EntertainmentSet
                                       where entertainment.Deleted == false && entertainment.EntertainmentId == id
                                       select entertainment).Single<Entertainment>();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return EntertainmentReturn;
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
                objContex.EntertainmentSet.Add(entertainment);
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
        /// Method for insert a new Entertainment with image
        /// </summary>
        /// <param name="entertainment"> object from class Entertainment for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(Entertainment entertainment, ImageEnter image, ModelUnibookContainer objContex)
        {
            try
            {
                var LastId = objContex.EntertainmentSet.OrderByDescending(x => x.EntertainmentId).First().EntertainmentId;
               // image.EntertainmentId = 
                objContex.EntertainmentSet.Add(entertainment);
                objContex.ImageEnterSet.Add(image);
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
        /// Method for Update Entertainment
        /// </summary>
        /// <param name="entertainment">Object to update</param>
        /// <param name="objContex"></param>
        public static void Update(ModelUnibookContainer objContex)
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
        /// <param name="id">id from Entertaiment for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                Entertainment entertainment = objContex.EntertainmentSet.Find(id);
                entertainment.Deleted = true;
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
