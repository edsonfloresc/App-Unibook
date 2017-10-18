using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.NewsBrl;

namespace Univalle.Fie.Sistemas.Unibook.WebNewsService
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

        ModelUnibookContainer dbcontext = new ModelUnibookContainer();
        [WebMethod]
        public void InsertImageNew(ImageNews imagenew)
        {
            try
            {
                ImageNewBrl.Insertar(imagenew, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void UpdateImageNew(ImageNews imagenew)
        {
            try
            {
                ImageNewBrl.Update(imagenew, dbcontext);
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
        public ImageNews GetImageNew(int id)
        {
            ImageNews imagenew = null;
            try
            {
                imagenew = ImageNewBrl.Get(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return imagenew;

        }
    }
}
