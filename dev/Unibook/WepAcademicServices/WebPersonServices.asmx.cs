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
    /// Descripción breve de WebPersonServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(PersonDto personDto)
        {
            try
            {
                PersonBrl.Insert(personDto, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(PersonDto personDto)
        {
            try
            {             
                PersonBrl.Update(personDto,objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Delete(long id)
        {
            try
            {
                PersonBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public PersonDto Get(long id)
        {
            PersonDto personDto = null;

            try
            {
                personDto = PersonBrl.GetDto(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personDto;
        }
    }
}
