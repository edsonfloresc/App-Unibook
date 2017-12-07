using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WebEntertainmentsServices
{
    /// <summary>
    /// Descripción breve de WebImageService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebImageService : System.Web.Services.WebService
    {
        ModelUnibookContainer content = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(ImageEnterDto image)
        {
            try
            {
                ImageBrl.Insert(image, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(ImageEnterDto image)
        {
            try
            {
                ImageEnterDto image1 = ImageBrl.GetDto(int.Parse(image.ImageId.ToString()), content);
                image1.PathImage = image.PathImage;

                ImageBrl.Update(image1, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Delete(int id)
        {
            try
            {
                ImageBrl.Delete(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public ImageEnterDto Get(int id)
        {
            ImageEnterDto image = null;
            try
            {
                image = ImageBrl.GetDto(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return image;

        }
    }
}
