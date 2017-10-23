using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsDal;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl
{
    public class CommentListBrl
    {
        #region metodo
        public static List<CommentEnterDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<CommentEnterDto> commentList = new List<CommentEnterDto>();
                foreach (var item in CommentListDal.Get(objContex))
                {
                    CommentEnterDto comment = new CommentEnterDto()
                    {
                        Deleted = item.Deleted,
                        CommentText = item.CommentText,
                        DateHour = item.DateHour,
                        CommentId = item.CommentId,
                        Entertainment = new EntertainmentDto() { EntertainmentId = item.Entertainment.EntertainmentId, Title = item.Entertainment.Title, PlaceAddress= item.Entertainment.PlaceAddress, DateHour=item.Entertainment.DateHour, Details = item.Entertainment.Details, Discontinued= item.Entertainment.Discontinued, Deleted= item.Entertainment.Deleted },
                        User = new UserDto() { UserId = item.User.UserId, Email = item.User.Email, Password = item.User.Password, Deleted = item.User.Deleted, RoleId = item.User.RoleId }

                    };

                    commentList.Add(comment);
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
        #endregion
    }
}
