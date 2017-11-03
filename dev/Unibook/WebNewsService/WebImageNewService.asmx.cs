using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;
namespace Univalle.Fie.Sistemas.UniBook.WebNewsService
{
    /// <summary>
    /// Descripción breve de WebImageNewService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebImageNewService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        ModelUnibookContainer dbcontext = new ModelUnibookContainer();
        [WebMethod]
        public void InsertImageNew(ImageNewsDto imagenewdto)
        {
            try
            {
                ImageNewBrl.Insertar(imagenewdto, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void UpdateImageNew(ImageNewsDto imagenewsdto)
        {
            try
            {
                ImageNewBrl.Update(imagenewsdto, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void DeleteImageNew(int id)
        {
            try
            {
                ImageNewBrl.Delete(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public ImageNewsDto GetImageNew(int id)
        {
            ImageNewsDto imagenewsdto = null;
            try
            {
                imagenewsdto = ImageNewBrl.GetDto(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return imagenewsdto;

        }
    }
}
