using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
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

        ModelPeopleAppContainer dbcontex = new ModelPeopleAppContainer();


        [WebMethod]
        public void Insert(PersonDto personDto)
        {
            try
            {
                Person person = new Person();
                person.Id = personDto.Id;
                person.FirstName = personDto.FirstName;
                person.LastName = personDto.LastName;
                person.Deleted = personDto.Deleted;
                person.PersonType = PersonTypeBrl.Get(personDto.PersonType.Id, dbcontex);

                PersonBrl.Insertar(person, dbcontex);
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
                Person person = PersonBrl.Get(personDto.Id, dbcontex);
                person.FirstName = personDto.FirstName;
                person.LastName = personDto.LastName;
                person.PersonType = PersonTypeBrl.Get(personDto.PersonType.Id, dbcontex);
                PersonBrl.Update(dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Delete(Guid id)
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
        public PersonDto Get(Guid id)
        {
            PersonDto personDto = null;
            try
            {
                Person person = PersonBrl.Get(id, dbcontex);
                personDto = new PersonDto();
                personDto.Id = person.Id;
                personDto.FirstName = person.FirstName;
                personDto.LastName = person.LastName;
                personDto.Deleted = person.Deleted;
                personDto.PersonType = new CommonDto.PersonTypeDto();
                personDto.PersonType.Id = person.PersonType.Id;
                personDto.PersonType.Name = person.PersonType.Name;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personDto;

        }
    }
}
