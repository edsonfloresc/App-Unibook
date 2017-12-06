using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.Unibook.EntertainmentsBrl;
using Univalle.Fie.Sistemas.UniBook.CommonDto;

namespace Univalle.Fie.Sistemas.UniBook.WebEntertainmentsServices
{
    /// <summary>
    /// Descripción breve de WebCategoryService
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
   // [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  //  [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebCategoryService : System.Web.Services.WebService
    {

        ModelUnibookContainer content = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(CategoryEnterDto category)
        {
            try
            {
                CategoryBrl.Insert(category, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(CategoryEnterDto category)
        {
            try
            {
                CategoryEnterDto category1 = CategoryBrl.GetDto(category.CategoryId, content);
                category1.Description = category.Description;

                CategoryBrl.Update(category1, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Delete(int id)
        {
            try
            {
                CategoryBrl.Delete(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public CategoryEnterDto GetDto(int id)
        {
            CategoryEnterDto category = null;
            try
            {
                category = CategoryBrl.GetDto(id, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return category;

        }

        //[WebMethod]
        //public List<CategoryEnterDto> Get()
        //{
        //    List<CategoryEnterDto> personTypeList = new List<CategoryEnterDto>();

        //    try
        //    {
        //        personTypeList = CategoryListBrl.Get(content);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return personTypeList;
        //}
    }
}
