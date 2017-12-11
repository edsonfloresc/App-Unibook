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
        public static object ImageEnterDal { get; private set; }
        #region metodos
        /// <summary>
        /// Method for Get Entertainment like object
        /// </summary>
        /// <param name="id">id from Entertainment Table for search</param>
        /// <param name="objContex"></param>
        /// <returns>return a Entertainment Object</returns>
        public static Entertainment Get(long id, ModelUnibookContainer objContex)
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
        public static EntertainmentDto GetDto(long id, ModelUnibookContainer objContex)
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
                entertainmentDto.Deleted = entertainment.Deleted;
                entertainmentDto.Discontinued = entertainment.Discontinued;
                entertainmentDto.CategoryEnter = CategoryBrl.GetDto(1, objContex);
                //entertainmentDto.CategoryEnter = CategoryBrl.GetDto(entertainmentDto.CategoryEnter.CategoryId, objContex);
                //   entertainmentDto.Users = UserBrl.GetDto(entertainmentDto.Users.UserId, objContex);

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
                entertainment.User = UserBrl.Get(entertainmentDto.Users.UserId, objContex);

                EntertainmentDal.Insert(entertainment, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        
        /// <summary>
          /// Method for insert a new Entertainment without image
          /// </summary>
          /// <param name="entertainment"> object from class Entertainment for insert</param>
          /// <param name="objContex"></param>
        public static void InsertComplete(EntertainmentDto entertainmentDto, ImageEnterDto imageDto, ModelUnibookContainer objContex)
        {
            try
            {
                Entertainment entertainment = new Entertainment
                {
                    Title = entertainmentDto.Title,
                    PlaceAddress = entertainmentDto.PlaceAddress,
                    DateHour = entertainmentDto.DateHour,
                    Details = entertainmentDto.Details,
                    Deleted = entertainmentDto.Deleted,
                    Discontinued = entertainmentDto.Discontinued,
                    CategoryEnter = CategoryBrl.Get(entertainmentDto.CategoryEnter.CategoryId, objContex),
                    User = UserBrl.Get(entertainmentDto.Users.UserId, objContex)
                };

                ImageEnter image = new ImageEnter
                {
                    PathImage = (EntertainmentDal.GetLastId(objContex) + 1).ToString(),
                    Deleted = false,
                    Entertainment = EntertainmentBrl.Get((EntertainmentDal.GetLastId(objContex) + 1),objContex)


                };
                EntertainmentDal.Insert(entertainment,image, objContex);


              
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
                Entertainment entertainment = EntertainmentBrl.Get(long.Parse(entertainmentDto.EntertainmentId.ToString()), objContex);
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