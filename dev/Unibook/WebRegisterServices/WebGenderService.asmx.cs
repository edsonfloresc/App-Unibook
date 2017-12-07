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
    /// Summary description for WebGenderService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebGenderService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();

        [WebMethod]
        public GenderDto Get(int id)
        {
            GenderDto genderDto = null;
            try
            {
<<<<<<< HEAD
                genderDto = GenderBrl.GetDto(id, dbcontex);
=======
                genderDto = GenderBrl.GetDto(1, dbcontex);
>>>>>>> master

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return genderDto;

        }
<<<<<<< HEAD
=======

        [WebMethod]
        public List<GenderDto> GetAll()
        {
            try
            {
                return GenderBrl.GetAll(dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
>>>>>>> master
    }
}
