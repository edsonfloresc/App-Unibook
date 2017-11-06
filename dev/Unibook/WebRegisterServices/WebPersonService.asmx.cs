using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebRegisterServices
{
    /// <summary>
    /// Summary description for WebPersonService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebPersonService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();


        [WebMethod]
        public void Insert(PersonDto roleDto)
        {
            try
            {
                PersonBrl.Insert(roleDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(PersonDto roleDto)
        {
            try
            {
                PersonBrl.Update(roleDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public PersonDto Get(long id)
        {
            PersonDto person = null;
            try
            {
                person = PersonBrl.GetDto(id, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;

        }
    }
}
