using System;
using System.Collections.Generic;
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
        public static void Insertar(UserDto userDto, ModelUnibookContainer objContex)
        {
            try
            {
                User user = new User();
                user.Email = userDto.Email;
                user.Password = userDto.Password;
                user.Deleted = userDto.Deleted;
                user.Role = RoleBrl.Get(userDto.Role.RoleId,objContex);
                //user.Person = PersonBrl.Get(userDto.Person.PersonId, objContex);
                UserDal.Insert(user, objContex);
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
                userDto.Password = user.Password;
                userDto.Deleted = user.Deleted;
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
                user.Password = userDto.Password;
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
    }
}
