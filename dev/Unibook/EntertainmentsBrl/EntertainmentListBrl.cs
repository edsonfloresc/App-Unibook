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
    public class EntertainmentListBrl
    {
        #region metodo
        public static List<EntertainmentDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<EntertainmentDto> entertainmentList = new List<EntertainmentDto>();
                foreach (var item in EntertainmentListDal.Get(objContex))
                {
                    EntertainmentDto enterteinment = new EntertainmentDto()
                    {
                        Deleted = item.Deleted,
                        Title = item.Title,
                        DateHour = item.DateHour,
                        PlaceAddress = item.PlaceAddress,
                        Details = item.Details,
                        Discontinued = item.Discontinued,
                        CategoryEnter = new CategoryEnterDto() { CategoryId = item.CategoryEnter.CategoryId, Description = item.CategoryEnter.Description, Deleted = item.CategoryEnter.Deleted },
                  //      User = new UserDto() { UserId = item.User.UserId, Email = item.User.Email, Password = item.User.Password, Deleted = item.User.Deleted }


                    };

                    entertainmentList.Add(enterteinment);
                }

                return entertainmentList;
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
