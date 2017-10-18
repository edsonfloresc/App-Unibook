using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsDal;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class ImageNewBrl
    {
        /// <summary>
        /// Create a new ImageNews
        /// </summary>
        /// <param name="ImageNews"></param>
        /// <param name="objContex"></param>
        public static void Insertar(ImageNews imagenews, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNewDal.Insert(imagenews, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Get a ImageNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static ImageNews Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return ImageNewDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="ImageNews"></param>
        /// <param name="objContex"></param>
        public static void Update(ImageNews imagenews, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNewDal.Update(imagenews, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Deleted a ImageNews
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                ImageNewDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
