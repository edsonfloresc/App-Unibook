using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsDal;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl
{
    public class ImageBrl
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



            try
            {
                return ImageDal.Get(id, objContex);
            }

            catch (Exception)
            {

            }

            return null;
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
                ImageDal.Insert(image, objContex);
            }

            catch (Exception)
            {

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
                ImageDal.Update(objContex);
            }

            catch (Exception)
            {

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
                ImageDal.Delete(id, objContex);
            }

            catch (Exception)
            {

            }
        }
        #endregion
    }
}
