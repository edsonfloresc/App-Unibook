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
    public class UserCareerBrl
    {
        /// <summary>
        /// Create a new user Career
        /// </summary>
        /// <param name="userCareer"></param>
        /// <param name="objContex"></param>
        public static void Insert(UserCareerDto userCareerDto, ModelUnibookContainer objContex)
        {
            try
            {
                UserCareer userCareer = new UserCareer();
                userCareer.UserCareerId = userCareerDto.UserCareerId;
                userCareer.User = UserBrl.Get(userCareerDto.User.UserId, objContex);
                userCareer.Career = CareerBrl.Get(userCareerDto.Career.CareerId, objContex);
                UserCareerDal.Insert(userCareer, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get a user Career with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static UserCareer Get(long id, ModelUnibookContainer objContex)
        {
            UserCareer userCareer = null;
            try
            {
                userCareer = UserCareerDal.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userCareer;
        }

        /// <summary>
        /// Get a user Career with identifier
        /// </summary>
        /// <param name="id"></param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static UserCareerDto GetDto(int id, ModelUnibookContainer objContex)
        {
            UserCareerDto userCareerDto = null;
            try
            {
                UserCareer userCareer = UserCareerDal.Get(id, objContex);
                userCareerDto.UserCareerId = userCareer.UserCareerId;
                userCareerDto.User = new UserDto();
                userCareerDto.User.UserId = userCareer.User.UserId;
                userCareerDto.User.Email = userCareer.User.Email;
                userCareerDto.User.Deleted = userCareer.User.Deleted;
                userCareerDto.User.Role = new RoleDto();
                userCareerDto.User.Role.RoleId = userCareer.User.Role.RoleId;
                userCareerDto.User.Role.Name = userCareer.User.Role.Name;
                userCareerDto.User.Role.Deleted = userCareer.User.Role.Deleted;
                userCareerDto.User.Person = new PersonDto();
                userCareerDto.Career = new CareerDto();
                userCareerDto.Career.CareerId = userCareer.Career.CareerId;
                userCareerDto.Career.Name = userCareer.Career.Name;
                userCareerDto.Career.Deleted = userCareer.Career.Deleted;
                userCareerDto.Career.Faculty = new FacultyDto();
                userCareerDto.Career.Faculty.FacultyId = userCareer.Career.Faculty.FacultyId;
                userCareer.Career.Faculty.Name = userCareer.Career.Faculty.Name;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userCareerDto;
        }



        /// <summary>
        /// Update changes in the context
        /// </summary>
        /// <param name="userCareer"></param>
        /// <param name="objContex"></param>
        public static void Update(UserCareerDto userCareerDto, ModelUnibookContainer objContex)
        {
            try
            {
                UserCareer userCareer = UserCareerBrl.Get(userCareerDto.UserCareerId, objContex);
                userCareer.UserCareerId = userCareerDto.UserCareerId;
                userCareer.User = UserBrl.Get(userCareerDto.User.UserId, objContex);
                userCareer.Career = CareerBrl.Get(userCareerDto.Career.CareerId, objContex);
                UserCareerDal.Update(userCareer, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
