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
    public class ImageBrl
    {
        #region metodos
        /// <summary>
        /// Method for get a Image like object
        /// </summary>
        /// <param name="id">id from Image</param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static ImageEnter Get(int id, ModelUnibookContainer objContex)
        {



            try
            {
                return ImageDal.Get(id, objContex);
            }

            catch (Exception)
            {

            }

            return null;
        }


        /// <summary>
        /// Method for get a Image like object
        /// </summary>
        /// <param name="id">id from Image</param>
        /// <param name="objContex"></param>
        /// <returns></returns>
        public static ImageEnterDto GetDto(int id, ModelUnibookContainer objContex)
        {


            ImageEnterDto imageDto = null;
            try
            {
                ImageEnter image = ImageDal.Get(id, objContex);
                imageDto = new ImageEnterDto
                {
                    ImageId = image.ImageId,
                    PathImage = image.PathImage,
                    Deleted = image.Deleted
                };

                //imageDto.Entertainment = new EntertainmentDto();
                //imageDto.Entertainment.EntertainmentId = image.Entertainment.EntertainmentId;
                //imageDto.Entertainment.Title = image.Entertainment.Title;
                //imageDto.Entertainment.PlaceAddress = image.Entertainment.PlaceAddress;
                //imageDto.Entertainment.DateHour = image.Entertainment.DateHour;
                //imageDto.Entertainment.Details = image.Entertainment.Details;
                //imageDto.Entertainment.Deleted = image.Entertainment.Deleted;
                //imageDto.Entertainment.Discontinued = image.Entertainment.Discontinued;


            }

            catch (Exception ex)
            {
                throw ex;
            }

            return imageDto;
        }

        /// <summary>
        /// Method for insert a Image
        /// </summary>
        /// <param name="image">object for insert</param>
        /// <param name="objContex"></param>
        public static void Insert(ImageEnterDto imageDto, ModelUnibookContainer objContex)
        {
            try
            {

                ImageEnter image = new ImageEnter();
                image.ImageId = imageDto.ImageId;
                image.PathImage = imageDto.PathImage;
                image.Deleted = imageDto.Deleted;
                image.Entertainment = EntertainmentBrl.Get(int.Parse(imageDto.Entertainment.EntertainmentId.ToString()), objContex);

                ImageDal.Insert(image, objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Method for update a image object in database 
        /// </summary>
        /// <param name="objContex"></param>
        public static void Update(ImageEnterDto imageDto, ModelUnibookContainer objContex)
        {
            try
            {
                ImageEnter image = ImageBrl.Get(int.Parse(imageDto.ImageId.ToString()), objContex);
                image.ImageId = imageDto.ImageId;
                image.PathImage = imageDto.PathImage;
                image.Deleted = imageDto.Deleted;
               // image.Entertainment = EntertainmentBrl.Get(int.Parse(imageDto.Entertainment.EntertainmentId.ToString()), objContex);


                ImageDal.Update(objContex);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method for deleted in presentation but put true en deleted image
        /// </summary>
        /// <param name="id">id from image object</param>
        /// <param name="objContex"></param>
        public static void Delete(int id, ModelUnibookContainer objContex)
        {
            try
            {
                ImageDal.Delete(id, objContex);
            }

            catch (Exception)
            {

            }
        }
        #endregion
    }
}
