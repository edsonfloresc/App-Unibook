using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto.Models;
using Univalle.Fie.Sistemas.UniBook.LoginBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebLoginServices
{
    /// <summary>
    /// Descripción breve de WebUserLoginService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebUserLoginService : System.Web.Services.WebService
    {
        private ModelUnibookContainer dbContext = new ModelUnibookContainer();

        [WebMethod]
        public bool Login(LoginModel user)
        {
            try
            {
                return UserLoginBrl.Login(user, dbContext);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool ChangePassword(ChangePasswordModel user)
        {
            try
            {
                return UserLoginBrl.ChangePassword(user, dbContext);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
