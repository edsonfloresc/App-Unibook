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
    /// Summary description for WebCategoryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCategoryService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();

        [WebMethod]
        public CategoryDto Get(short id)
        {
            CategoryDto categoryDto = null;
            try
            {
                categoryDto = CategoryBrl.GetDto(id, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return categoryDto;

        }

        [WebMethod]
        public void Insert(CategoryDto categoryDto)
        {
            try
            {
                CategoryBrl.Insert(categoryDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(CategoryDto categoryDto)
        {
            try
            {
                CategoryBrl.Update(categoryDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
