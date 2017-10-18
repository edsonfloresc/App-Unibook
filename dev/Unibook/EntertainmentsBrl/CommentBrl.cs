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
    public class CommentBrl
    {
        #region metodos
        /// <summary>
        /// Method for Get CommentEnter like object
        /// </summary>
        /// <param name="id">id from CommentEnter Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a CommentEnter Object</returns>
        public static CommentEnter Get(int id, ModelUnibookContainer objContex)
        {

            try
            {
                return CommentDal.Get(id, objContex);
            }

            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Method for insert a new CommentEnter 
        /// </summary>
        /// <param name="comment"> object from class CommentEnter for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(CommentEnter comment, ModelUnibookContainer objContex)
        {
            try
            {
                CommentDal.Insert(comment, objContex);
            }

            catch (Exception)
            {

            }
        }


        /// <summary>
        /// Method for Update CommentEnter
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(ModelUnibookContainer objContex)
        {
            try
            {
                CommentDal.Update(objContex);
            }

            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from CommentEnter for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentDal.Delete(id, objContex);
            }

            catch (Exception)
            {

            }
        }
        #endregion
    }
}
