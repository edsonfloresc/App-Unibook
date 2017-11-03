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
    /// Descripción breve de WebPersonListService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonListService : System.Web.Services.WebService
    {
        ModelPeopleAppContainer dbcontex = new ModelPeopleAppContainer();

        [WebMethod]
        public List<PersonDto> Get()
        {
            try
            {
                List<PersonDto> personList = new List<PersonDto>();
                foreach (var item in PersonListBrl.Get(dbcontex))
                {
                    PersonDto person = new PersonDto()
                    {
                        Deleted = item.Deleted,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        Id = item.Id,
                        PersonType = new CommonDto.PersonTypeDto() { Id = item.PersonType.Id, Name = item.PersonType.Name }
                    };

                    personList.Add(person);
                }

                return personList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
