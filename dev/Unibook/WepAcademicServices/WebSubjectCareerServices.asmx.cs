using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Univalle.Fie.Sistemas.Unibook.Common;
using Univalle.Fie.Sistemas.UniBook.AcademicBrl;

namespace WepAcademicServices
{
    /// <summary>
    /// Descripción breve de WebSubjectCareerServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebSubjectCareerServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(SubjectCareer subjectCareer)
        {
            try
            {
                SubjectCareerBrl.Insert(subjectCareer, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(SubjectCareer subjectCareer)
        {
            try
            {
                SubjectCareer subjectCareerUpdate = SubjectCareerBrl.Get(subjectCareer.SubjectCareerId, objContex);
                subjectCareerUpdate.Career = subjectCareer.Career;
                subjectCareerUpdate.Subject = subjectCareer.Subject;
                SubjectCareerBrl.Update(objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public SubjectCareer Get(int id)
        {
            SubjectCareer subjectCareer = null;

            try
            {
                subjectCareer = SubjectCareerBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return subjectCareer;
        }
    }
}
