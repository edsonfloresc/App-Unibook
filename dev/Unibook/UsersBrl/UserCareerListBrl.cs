using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersDal;

namespace Univalle.Fie.Sistemas.UniBook.UsersBrl
{
    public class UserCareerListBrl
    {
        /// <summary>
        /// Get list gender 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<UserCareerDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<UserCareerDto> userCareerList = new List<UserCareerDto>();
                foreach (var item in UserCareerListDal.Get(objContex))
                {
                    UserCareerDto userCareer = new UserCareerDto()
                    {
                        UserCareerId = item.UserCareerId,
                        Career = new CareerDto() { CareerId = item.Career.CareerId, Deleted = item.Career.Deleted, Name = item.Career.Name, Faculty = new FacultyDto() { Name = item.Career.Faculty.Name, Deleted = item.Career.Faculty.Deleted, FacultyId = item.Career.Faculty.FacultyId} },
                        User = new UserDto() { UserId = item.User.UserId, Email = item.User.Email, Deleted = item.User.Deleted, Password = new PasswordDto() { PasswordId = 1, Date = DateTime.Now, State = 1, Psw = "1234", UserId = 1 }, Role = new RoleDto() { RoleId = item.User.Role.RoleId, Name = item.User.Role.Name, Deleted = item.User.Role.Deleted }, Person = new PersonDto() }
                    };

                    userCareerList.Add(userCareer);
                }

                return userCareerList;
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
