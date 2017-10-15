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
    /// Descripción breve de WebSubjectServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebSubjectServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(Subject subject)
        {
            try
            {
                SubjectBrl.Insert(subject, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(Subject subject)
        {
            try
            {
                Subject subjectUpdate = SubjectBrl.Get(subject.SubjectId, objContex);
                subjectUpdate.Name = subject.Name;
                subjectUpdate.Description = subject.Description;
                subjectUpdate.Deleted = subject.Deleted;
                SubjectBrl.Update(objContex);
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
                SubjectBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public Subject Get(int id)
        {
            Subject subject = null;

            try
            {
                subject = SubjectBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return subject;
        }
    }
}
