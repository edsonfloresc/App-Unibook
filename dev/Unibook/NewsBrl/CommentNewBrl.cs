using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsDal;
using Univalle.Fie.Sistemas.Unibook.CommonDto;

namespace Univalle.Fie.Sistemas.Unibook.NewsBrl
{
    public class CommentNewBrl
    {
        /// <summary>
        /// Create a new CommentNews
        /// </summary>
        /// <param name="CommentNews"></param>
        /// <param name="objContex"></param>
        public static void Insertar(CommentNewsDto commentnewsdto, ModelUnibookContainer objContex)
        {
            try
            {
                CommentNews commentnews = new CommentNews();
                commentnews.Message = commentnewsdto.Message;
                commentnews.Date = commentnewsdto.Date;
                commentnews.Deleted = commentnewsdto.Deleted;
                CommentNewDal.Insert(commentnews, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a CommentNews with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static CommentNewsDto GetDto(int id, ModelUnibookContainer objContex)
        {
            CommentNewsDto commentnewsdto = null;
            try
            {
                CommentNews commentnews = CommentNewDal.Get(id, objContex);
                commentnewsdto = new CommentNewsDto();
                
                commentnewsdto.Message = commentnews.Message;
                commentnewsdto.Date = commentnews.Date;
                commentnewsdto.Deleted = commentnews.Deleted;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return commentnewsdto;
        }

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
            catch (Exception )
            {
                
            }

            return null;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="CommentNews"></param>
        /// <param name="objContex"></param>
        public static void Update(CommentNewsDto commentnewsdto, ModelUnibookContainer objContex)
        {
            try
            {
                CommentNews commentnews = CommentNewDal.Get(commentnewsdto.CommentId, objContex);
                commentnews.Message = commentnewsdto.Message;
                commentnews.Date = commentnewsdto.Date;
                commentnews.Deleted = commentnewsdto.Deleted;
                CommentNewDal.Update(commentnews, objContex);
            }
            catch (Exception ex)
            {
                throw ex;

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
