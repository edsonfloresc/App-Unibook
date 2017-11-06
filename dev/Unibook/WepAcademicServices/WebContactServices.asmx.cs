using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WepAcademicServices
{
    /// <summary>
    /// Descripción breve de WebContactServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebContactServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(ContactDto contactDto)
        {
            try
            {
                ContactBrl.Insert(contactDto, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(ContactDto contactDto)
        {
            try
            {              
                ContactBrl.Update(contactDto,objContex);
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
                ContactBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public ContactDto Get(int id)
        {
            ContactDto contactDto = null;

            try
            {
                contactDto = ContactBrl.GetDto(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contactDto;      
        }
    }
}
