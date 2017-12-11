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
    /// Summary description for WebQuestionsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebQuestionsService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();

        [WebMethod]
        public QuestionsDto Get(short id)
        {
            QuestionsDto questionsDto = null;
            try
            {
                questionsDto = QuestionsBrl.GetDto(id, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return questionsDto;

        }

        [WebMethod]
        public void Insert(QuestionsDto questionsDto)
        {
            try
            {
                QuestionsBrl.Insert(questionsDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(QuestionsDto questionsDto)
        {
            try
            {
                QuestionsBrl.Update(questionsDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
