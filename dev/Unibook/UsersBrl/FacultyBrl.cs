using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class FacultyBrl
    {
        /// <summary>
        /// Create a new faculty
        /// </summary>
        /// <param name="faculty"></param>
        /// <param name="objContex"></param>
        public static void Insertar(Faculty faculty, ModelUnibookContainer objContex)
        {
            try
            {
                FacultyDal.Insert(faculty, objContex);
            }
            catch (Exception)
            {


            }
        }

        /// <summary>
        /// Get a person with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static Faculty Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return FacultyDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(Faculty faculty, ModelUnibookContainer objContex)
        {
            try
            {
                FacultyDal.Update(faculty, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Deleted a faculty
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                FacultyDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
