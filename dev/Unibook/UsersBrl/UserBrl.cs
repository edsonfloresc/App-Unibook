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
    public class UserBrl
    {
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Insert(UserDto userDto, ModelUnibookContainer objContex)
        {
            try
            {
                User user = new User();
                user.Email = userDto.Email;
                user.Role = RoleBrl.Get(userDto.Role.RoleId, objContex);
                user.Person = PersonBrl.Get(userDto.Person.PersonId, objContex);
                user.Deleted = userDto.Deleted;

                Password password = new Password() { Psw = userDto.Password.Psw, State = userDto.Password.State, Date = userDto.Password.Date, User = user };
                UserDal.Insert(user, password, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a user with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static User Get(long id, ModelUnibookContainer objContex)
        {
            User user = null;
            try
            {

                user = UserDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// Get a user with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static UserDto GetDto(long id, ModelUnibookContainer objContex)
        {
            UserDto userDto = null;
            try
            {
                User user = UserDal.Get(id, objContex);
                userDto = new UserDto();
                userDto.Email = user.Email;
                userDto.Deleted = user.Deleted;
                userDto.Role = new RoleDto() { RoleId = user.Role.RoleId, Name = user.Role.Name, Deleted = user.Role.Deleted};
                userDto.Person = new PersonDto() { PersonId = user.Person.PersonId, Name = user.Person.Name, Deleted = user.Person.Deleted, BirthDay = user.Person.Birthday, LastName = user.Person.LastName, Gender = new GenderDto() { GenderId = user.Person.Gender.GenderId, Name = user.Person.Gender.Name }, User = new UserDto() };
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userDto;
        }

        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="role"></param>
        /// <param name="objContex"></param>
        public static void Update(UserDto userDto, ModelUnibookContainer objContex)
        {
            try
            {
                User user = UserBrl.Get(userDto.UserId, objContex); ;
                user.Email = userDto.Email;
                user.Deleted = userDto.Deleted;
                UserDal.Update(user, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deleted a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        public static void Delete(long id, ModelUnibookContainer objContex)
        {
            try
            {
                UserDal.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get list user
        /// </summary>
        /// <param name="objContex">Get table to object</param>
        /// <returns></returns>
        public static List<UserDto> GetAll(ModelUnibookContainer objContex)
        {
            try
            {
                List<UserDto> roleList = new List<UserDto>();
                foreach (var item in UserDal.GetAll(objContex))
                {
                    roleList.Add(UserBrl.GetDto(item.UserId, objContex));
                }

                return roleList;
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
