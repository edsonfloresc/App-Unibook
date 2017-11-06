using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.UniBook.Common;
using Univalle.Fie.Sistemas.UniBook.CommonDto;
using Univalle.Fie.Sistemas.UniBook.UsersBrl;

namespace Univalle.Fie.Sistemas.UniBook.WebRegisterServices
{
    /// <summary>
    /// Summary description for WebFacultyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebFacultyService : System.Web.Services.WebService
    {

        ModelUnibookContainer dbcontex = new ModelUnibookContainer();


        [WebMethod]
        public void Insert(FacultyDto facultyDto)
        {
            try
            {
                FacultyBrl.Insertar(facultyDto, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public void Update(FacultyDto facultyDto)
        {
            try
            {
                FacultyBrl.Update(facultyDto, dbcontex);
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
                FacultyBrl.Delete(id, dbcontex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [WebMethod]
        public FacultyDto Get(int id)
        {
            FacultyDto facultyDto = null;
            try
            {
                facultyDto = FacultyBrl.GetDto(id, dbcontex);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return facultyDto;

        }
    }
}
