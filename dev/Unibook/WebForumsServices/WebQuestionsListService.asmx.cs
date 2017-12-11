using ForumBrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace WebForumsServices
{
    /// <summary>
    /// Summary description for WebQuestionsListService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebQuestionsListService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();

        [WebMethod]
        public List<QuestionsDto> Get()
        {
            try
            {
                return QuestionsListBrl.Get(dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
