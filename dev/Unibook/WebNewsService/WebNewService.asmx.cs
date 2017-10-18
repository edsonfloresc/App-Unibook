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
    /// Descripción breve de WebNewService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebNewService : System.Web.Services.WebService
    {
        ModelUnibookContainer dbcontext = new ModelUnibookContainer();
        [WebMethod]
        public void InsertNew(News news)
        {
            try 
            {
                NewBrl.Insertar(news, dbcontext);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public void UpdateNew(News news)
        {
            try
            {
                NewBrl.Update(news, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void DeleteNew(int id)
        {
            try
            {
                NewBrl.Delete(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public News GetNew(int id)
        {
            News news = null;
            try
            {
                news = NewBrl.Get(id, dbcontext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return news;

        }
    }
}
