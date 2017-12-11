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
    /// Descripción breve de WebEntertainmentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebEntertainmentService : System.Web.Services.WebService
    {

        ModelUnibookContainer content = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(EntertainmentDto entertainment)
        {
            try
            {
                EntertainmentBrl.Insert(entertainment, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void InsertComplete(EntertainmentDto entertainment, ImageEnterDto image)
        {
            try
            {
                EntertainmentBrl.InsertComplete(entertainment, image, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [WebMethod]
        public void Update(EntertainmentDto entertainment)
        {
            try
            {
                EntertainmentDto entertainment1 = EntertainmentBrl.GetDto(long.Parse(entertainment.EntertainmentId.ToString()), content);
                entertainment1.Title = entertainment.Title;
                entertainment1.Details = entertainment.Details;
                entertainment1.DateHour = entertainment.DateHour;
                entertainment1.Discontinued = entertainment.Discontinued;
                entertainment1.Deleted = entertainment.Deleted;
               // entertainment1.CategoryEnter = CategoryBrl.GetDto(entertainment.CategoryEnter.CategoryId,content);
                EntertainmentBrl.Update(entertainment, content);
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
                EntertainmentBrl.Delete(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public EntertainmentDto Get(int id)
        {
            EntertainmentDto entertainment = null;
            try
            {
                entertainment = EntertainmentBrl.GetDto(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entertainment;

        }
    }
}
