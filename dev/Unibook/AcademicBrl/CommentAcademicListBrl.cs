using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.UniBook.AcademicDal;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.AcademicBrl
{
    public class CommentAcademicListBrl
    {
        /// <summary>
        /// Get list comments
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<CommentAcademicDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<CommentAcademicDto> commentList = new List<CommentAcademicDto>();
                foreach (var item in CommentAcademicListDal.Get(objContex))
                {                 
                    commentList.Add(CommentAcademicBrl.GetDto(item.CommentAcademicId,objContex));
                }

                return commentList;
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
    }
}
