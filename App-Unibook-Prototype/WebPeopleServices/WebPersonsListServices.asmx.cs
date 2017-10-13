using System;
using System.Collections.Generic;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebPeopleServices
{
    /// <summary>
    /// Descripción breve de WebPersonsListServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonsListServices : System.Web.Services.WebService
    {
        PeopleContainer dbcontex = new PeopleContainer();


        [WebMethod]
        public List<Person> Get()
        {
            try
            {
                return PersonsListBrl.Get(dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
