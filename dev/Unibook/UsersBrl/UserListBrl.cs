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
    public class UserListBrl
    {
        /// <summary>
        /// Get list person 
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<UserDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<UserDto> userList = new List<UserDto>();
                foreach (var item in UserListDal.Get(objContex))
                {
                    UserDto user = new UserDto()
                    {
                        Deleted = item.Deleted,
                        Email = item.Email,
                        Password = item.Password,
                        UserId = item.UserId,
                        Role = new RoleDto() { RoleId = item.Role.RoleId, Name = item.Role.Name, Deleted = item.Role.Deleted },
                        Person = new PersonDto() { PersonId = item.Person.PersonId, Name = item.Person.Name, BirthDay = item.Person.Birthday, LastName = item.Person.LastName, Deleted = item.Person.Deleted, Gender = new GenderDto() { Name = item.Person.Gender.Name, GenderId = item.Person.Gender.GenderId}, User = new UserDto() }
                    };

                    userList.Add(user);
                }

                return userList;
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
