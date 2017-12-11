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
                    //EntertainmentDto enterteinment = new EntertainmentDto()
                    //{
                    //    //EntertainmentId = item.EntertainmentId,
                    //    //Deleted = item.Deleted,
                    //    //Title = item.Title,
                    //    //DateHour = item.DateHour,
                    //    //PlaceAddress = item.PlaceAddress,
                    //    //Details = item.Details,
                    //    //Discontinued = item.Discontinued,
                    //    //CategoryEnter = new CategoryEnterDto() { CategoryId = item.CategoryEnter.CategoryId, Description = item.CategoryEnter.Description, Deleted = item.CategoryEnter.Deleted },
                    //    //Users = new UserDto() { UserId = item.User.UserId, Email = item.User.Email, Deleted = item.User.Deleted, Role = new RoleDto() { RoleId = item.User.Role.RoleId, Name = item.User.Role.Name, Deleted = item.User.Role.Deleted }, Person = new PersonDto() { PersonId = item.User.Person.PersonId, Name = item.User.Person.Name, LastName = item.User.Person.LastName, Gender = new GenderDto() { GenderId = item.User.Person.Gender.GenderId, Name = item.User.Person.Gender.Name } } }



                    //};

                    //entertainmentList.Add(enterteinment);
                    entertainmentList.Add(EntertainmentBrl.GetDto(item.EntertainmentId,objContex));
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

