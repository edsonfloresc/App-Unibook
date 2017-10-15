using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace WepAcademicServices
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
        public void Insert(Person person)
        {
            try
            {
                PersonBrl.Insert(person, objContex);
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
                Person personUpdate = PersonBrl.Get(person.PersonId, objContex);
                personUpdate.Name = person.Name;
                personUpdate.LastName = person.LastName;
                personUpdate.BirthDay = person.BirthDay;
                personUpdate.Deleted = person.Deleted;
                personUpdate.Gender = person.Gender;
                PersonBrl.Update(objContex);
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
        public Person Get(long id)
        {
            Person person = null;

            try
            {
                person = PersonBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }
    }
}
