using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Data.Entity.Validation;
>>>>>>> master
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
<<<<<<< HEAD
        public static void Insertar(UserDto userDto, ModelUnibookContainer objContex)
=======
        public static void Insert(UserDto userDto, ModelUnibookContainer objContex)
>>>>>>> master
        {
            try
            {
                User user = new User();
                user.Email = userDto.Email;
<<<<<<< HEAD
                user.Password = userDto.Password;
                user.Deleted = userDto.Deleted;
                user.Role = RoleBrl.Get(userDto.Role.RoleId,objContex);
                //user.Person = PersonBrl.Get(userDto.Person.PersonId, objContex);
                UserDal.Insert(user, objContex);
=======
                user.Role = RoleBrl.Get(userDto.Role.RoleId, objContex);
                user.Person = PersonBrl.Get(userDto.Person.PersonId, objContex);
                user.Deleted = userDto.Deleted;

                PasswordDto password = userDto.Password;
                UserDal.Insert(user, password, objContex);
>>>>>>> master
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
<<<<<<< HEAD
                userDto.UserId = user.UserId;
                userDto.Email = user.Email;
                userDto.Password = user.Password;
                userDto.Deleted = user.Deleted;
             }
=======
                userDto.Email = user.Email;
                userDto.Deleted = user.Deleted;
                userDto.Role = new RoleDto() { RoleId = user.Role.RoleId, Name = user.Role.Name, Deleted = user.Role.Deleted};
                userDto.Person = new PersonDto() { PersonId = user.Person.PersonId, Name = user.Person.Name, Deleted = user.Person.Deleted, BirthDay = user.Person.Birthday, LastName = user.Person.LastName, Gender = new GenderDto() { GenderId = user.Person.Gender.GenderId, Name = user.Person.Gender.Name }, User = new UserDto() };
            }
>>>>>>> master
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
<<<<<<< HEAD
                user.Password = userDto.Password;
=======
>>>>>>> master
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
<<<<<<< HEAD
=======

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
>>>>>>> master
    }
}
