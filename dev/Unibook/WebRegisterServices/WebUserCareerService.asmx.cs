using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebRegisterServices
{
    /// <summary>
    /// Summary description for WebUserCareerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebUserCareerService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();


        [WebMethod]
        public void Insert(UserCareerDto userCareerDto)
        {
            try
            {
                UserCareerBrl.Insertar(userCareerDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(UserCareerDto userCareerDto)
        {
            try
            {
                UserCareerBrl.Update(userCareerDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [WebMethod]
        public UserCareerDto Get(int id)
        {
            UserCareerDto userCareerDto = null;
            try
            {
                userCareerDto = UserCareerBrl.GetDto(id, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return userCareerDto;

        }
    }
}
