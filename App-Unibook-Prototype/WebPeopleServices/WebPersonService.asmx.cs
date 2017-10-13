using System;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.PeopleBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebPeopleServices
{
    /// <summary>
    /// Descripción breve de WebPersonService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonService : System.Web.Services.WebService
    {
        PeopleContainer dbcontex = new PeopleContainer();


        [WebMethod]
        public void Insert(Person person)
        {
            try
            {
                PersonBrl.Insertar(person, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(Person person)
        {
            try
            {
                Person person1 = PersonBrl.Get(person.Id, dbcontex);
                person1.FirstName = person.FirstName;
                person1.LastName = person.LastName;
                PersonBrl.Update(dbcontex);
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
                PersonBrl.Delete(id, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        [WebMethod]
        public Person Get(int id)
        {
            Person person = null;
            try
            {
                person= PersonBrl.Get(id, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;

        }
    }
}
