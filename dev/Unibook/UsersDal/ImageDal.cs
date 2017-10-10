using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.Unibook.Common;

namespace Univalle.Fie.Sistemas.Unibook.UsersDal
{
    public class ImageDal
    {
        #region metodos
     
        /// <summary>
        /// Method for get a Image like object
        /// </summary>
        /// <param name="id">id from Image</param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static ImageEnter Get(int id, ModelUnibookContainer objContex)
        {
            ImageEnter ImageReturn = null;


            try
            {
                ImageReturn = (from image in objContex.ImageEnterSet
                               where image.Deleted == false && image.ImageId == id
                               select image).Single<ImageEnter>();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ImageReturn;
        }

        /// <summary>
        /// Method for insert a Image
        /// </summary>
        /// <param name="image">object for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(ImageEnter image, ModelUnibookContainer objContex)
        {
            try
            {
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
     /// Method for update a image object in database 
     /// </summary>
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
       /// Method for deleted in presentation but put true en deleted image
       /// </summary>
       /// <param name="id">id from image object</param>
       /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                ImageEnter image = objContex.ImageEnterSet.Find(id);
                image.Deleted = true;
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
