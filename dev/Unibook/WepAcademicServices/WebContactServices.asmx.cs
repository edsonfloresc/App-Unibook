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
    /// Descripción breve de WebContactServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebContactServices : System.Web.Services.WebService
    {
        ModelUnibookContainer objContex = new ModelUnibookContainer();

        [WebMethod]
        public void Insert(Contact contact)
        {
            try
            {
                ContactBrl.Insert(contact, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public void Update(Contact contact)
        {
            try
            {
                Contact contactUpdate = ContactBrl.Get(contact.ContactId, objContex);
                contactUpdate.Data = contact.Data;
                contactUpdate.Description = contact.Description;
                contactUpdate.Deleted = contact.Deleted;
                contactUpdate.Person = contact.Person;
                ContactBrl.Update(objContex);
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
                ContactBrl.Delete(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public Contact Get(int id)
        {
            Contact contact = null;

            try
            {
                contact = ContactBrl.Get(id, objContex);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contact;
        }
    }
}
