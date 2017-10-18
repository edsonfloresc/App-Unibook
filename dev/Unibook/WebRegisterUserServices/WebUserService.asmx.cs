using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
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
        public void InsertUser(User user)
        {
            try
            {
                UserBrl.Insertar(user, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void UpdateUser(User user)
        {
            try
            {
                UserBrl.Update(user, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void DeleteUser(int id)
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
        public User GetUser(long id)
        {
            User user = null;
            try
            {
                user = UserBrl.Get(id, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;

        }
    }
}
