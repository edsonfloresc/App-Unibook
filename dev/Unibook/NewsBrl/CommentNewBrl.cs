using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsDal;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class CommentNewBrl
    {
        /// <summary>
        /// Create a new CommentNews
        /// </summary>
        /// <param name="CommentNews"></param>
        /// <param name="objContex"></param>
        public static void Insertar(CommentNews commentnews, ModelUnibookContainer objContex)
        {
            try
            {
                CommentNewDal.Insert(commentnews, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Get a CommentNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CommentNews Get(int id, ModelUnibookContainer objContex)
        {
            try
            {
                return CommentNewDal.Get(id, objContex);
            }
            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="CommentNews"></param>
        /// <param name="objContex"></param>
        public static void Update(CommentNews commentnews, ModelUnibookContainer objContex)
        {
            try
            {
                CommentNewDal.Update(commentnews, objContex);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Deleted a CommentNews
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                CommentNewDal.Delete(id, objContex);
            }
            catch (Exception)
            {

            }
        }
    }
}
