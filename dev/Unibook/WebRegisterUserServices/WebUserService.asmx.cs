using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace WebRegisterUserServices
{
    /// <summary>
    /// Summary description for WebUserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebUserService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();


        [WebMethod]
        public void Insert(UserDto userDto)
        {
            try
            {
                UserBrl.Insertar(userDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(UserDto personDto)
        {
            try
            {
                UserBrl.Update(personDto, dbcontex);
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
                UserBrl.Delete(id, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public UserDto Get(long id)
        {
            UserDto personDto = null;
            try
            {
                personDto = UserBrl.GetDto(id, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personDto;

        }

    }
}
