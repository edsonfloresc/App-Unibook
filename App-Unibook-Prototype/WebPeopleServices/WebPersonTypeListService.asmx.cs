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
    /// Summary description for WebPersonTypeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonTypeListService : System.Web.Services.WebService
    {
        ModelPeopleAppContainer dbcontex = new ModelPeopleAppContainer();

        [WebMethod]
        public List<PersonTypeDto> Get()
        {
            List<PersonTypeDto> personTypeList = new List<PersonTypeDto>();

            try
            {
                personTypeList = PersonTypeListBrl.GetDto(dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personTypeList;
        }
    }
}
