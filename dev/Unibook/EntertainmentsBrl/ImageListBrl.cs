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
    public class ImageListBrl
    {
        #region metodo
        public static List<ImageEnterDto> Get(ModelUnibookContainer objContex)
        {
            try
            {
                List<ImageEnterDto> imageList = new List<ImageEnterDto>();
                foreach (var item in ImageListDal.Get(objContex))
                {
                    ImageEnterDto image = new ImageEnterDto()
                    {
                        Deleted = item.Deleted,
                        PathImage = item.PathImage,
                        ImageId = item.ImageId,
                        Entertainment = new EntertainmentDto() { EntertainmentId = item.Entertainment.EntertainmentId, Title = item.Entertainment.Title, PlaceAddress = item.Entertainment.PlaceAddress, DateHour = item.Entertainment.DateHour, Details = item.Entertainment.Details, Discontinued = item.Entertainment.Discontinued, Deleted = item.Entertainment.Deleted }
                    };

                    imageList.Add(image);
                }

                return imageList;
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
