using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsDal;
using Univalle.Fie.Sistemas.Unibook.Common;
using System.Data.Entity.Validation;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl
{
    public class EntertainmentBrl
    {
        #region metodos
        /// <summary>
        /// Method for Get Entertainment like object
        /// </summary>
        /// <param name="id">id from Entertainment Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a Entertainment Object</returns>
        public static Entertainment Get(int id, ModelUnibookContainer objContex)
        {



            try
            {
                return EntertainmentDal.Get(id, objContex);
            }

            catch (Exception)
            {

            }

            return null;
        }

        /// <summary>
        /// Method for Get Entertainment like object
        /// </summary>
        /// <param name="id">id from Entertainment Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a Entertainment Object</returns>
        public static EntertainmentDto GetDto(int id, ModelUnibookContainer objContex)
        {

            EntertainmentDto entertainmentDto = null;

            try
            {

                Entertainment entertainment = EntertainmentDal.Get(id, objContex);
                entertainmentDto = new EntertainmentDto();

                entertainmentDto.EntertainmentId = entertainment.EntertainmentId;
                entertainmentDto.Title = entertainment.Title;
                entertainmentDto.PlaceAddress = entertainment.PlaceAddress;
                entertainmentDto.DateHour = entertainment.DateHour;
                entertainmentDto.Details = entertainment.Details;
                //entertainmentDto.Deleted = entertainment.Deleted;
                //entertainmentDto.Discontinued = entertainment.Discontinued;
                //entertainmentDto.CategoryEnter = new CategoryEnterDto();
                //entertainmentDto.CategoryEnter.CategoryId = entertainment.CategoryEnter.CategoryId;
                //entertainmentDto.CategoryEnter.Description = entertainment.CategoryEnter.Description;
                //entertainmentDto.CategoryEnter.Deleted = entertainment.CategoryEnter.Deleted;
                //entertainmentDto.User = new UserDto();
                //entertainmentDto.User.UserId = entertainment.User.UserId;
                //entertainmentDto.User.Email = entertainment.User.Email;
                //entertainmentDto.User.Password = entertainment.User.Password;
                //entertainmentDto.User.Deleted = entertainment.User.Deleted;
               // entertainmentDto.User.RoleId = entertainment.User.RoleId;
            }

            catch (Exception)
            {
                return null;
            }

            return entertainmentDto;
        }

        /// <summary>
        /// Method for insert a new Entertainment without image
        /// </summary>
        /// <param name="entertainment"> object from class Entertainment for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(EntertainmentDto entertainmentDto, ModelUnibookContainer objContex)
        {
            try
            {
                Entertainment entertainment = new Entertainment();

                entertainment.Title = entertainmentDto.Title;
                entertainment.PlaceAddress = entertainmentDto.PlaceAddress;
                entertainment.DateHour = entertainmentDto.DateHour;
                entertainment.Details = entertainmentDto.Details;
                entertainment.Deleted = entertainmentDto.Deleted;
                entertainment.Discontinued = entertainmentDto.Discontinued;
                entertainment.CategoryEnter = CategoryBrl.Get(entertainmentDto.CategoryEnter.CategoryId, objContex);
                entertainment.Users = UserBrl.Get(entertainmentDto.User.UserId, objContex);

                EntertainmentDal.Insert(entertainment, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// Method for Update Entertainment
        /// </summary>
        /// <param name="entertainment">Object to update</param>
        /// <param name="objContex"></param>
        public static void Update(EntertainmentDto entertainmentDto, ModelUnibookContainer objContex)
        {
            try
            {
                Entertainment entertainment = EntertainmentBrl.Get(int.Parse(entertainmentDto.EntertainmentId.ToString()), objContex);
                entertainment.Title = entertainmentDto.Title;
                entertainment.PlaceAddress = entertainmentDto.PlaceAddress;
                entertainment.DateHour = entertainmentDto.DateHour;
                entertainment.Details = entertainmentDto.Details;
                entertainment.Deleted = entertainmentDto.Deleted;
                entertainment.Discontinued = entertainmentDto.Discontinued;
                entertainment.CategoryEnter = CategoryBrl.Get(entertainment.CategoryEnter.CategoryId, objContex);
                //entertainment.User = UserBrl.Get(int.Parse(entertainment.User.UserId.ToString()), objContex);


                EntertainmentDal.Update(objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method for Delete from presentation but not in database
        /// </summary>
        /// <param name="id">id from Entertaiment for make deleted on true</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                EntertainmentDal.Delete(id, objContex);
            }

            catch (Exception)
            {

            }
        }
        #endregion
    }
}
