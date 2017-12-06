using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models;
using System.ServiceModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppUnibookRegisterMvc.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private ILogger<ContactController> logger;

        public ContactController(ILogger<ContactController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
        }

        public List<ContactModel> ContactListModel
        {
            get
            {
                WebContactListServices.ContactDto[] contacts = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:ContactList:WebContactListServices");
                    //Create instance of SOAP client
                    WebContactListServices.WebContactListServicesSoapClient soapClient = new WebContactListServices.WebContactListServicesSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    contacts = soapClient.Get();
                }
                catch (System.Net.Http.HttpRequestException ex)
                {
                    _logger.LogCritical(ex.Message);
                    _logger.LogCritical(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex.Message);
                    _logger.LogCritical(ex.StackTrace);
                }

                List<ContactModel> contactModel = new List<ContactModel>();
                foreach (var contact in contacts)
                {
                    contactModel.Add(new ContactModel
                    {
                        ContactId = contact.ContactId,
                        Description = contact.Description,
                        Data = contact.Data,
                        Deleted = contact.Deleted,
                        Person = new PersonModel() { PersonId = contact.Person.PersonId + 1, Name = contact.Person.Name, LastName = contact.Person.LastName, BirthDay = contact.Person.BirthDay, Deleted = contact.Person.Deleted, Gender = new GenderModel() { GenderId = contact.Person.Gender.GenderId, Name = contact.Person.Gender.Name }, User = new UserModel() }
                    });
                }
                return contactModel;
            }
        }
        // GET: Contact
        public ActionResult Index()
        {
            List<ContactModel> model = null;
            try
            {
                model = ContactListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            WebContactServices.ContactDto contactDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Contact:WebContactServices");
                WebContactServices.WebContactServicesSoapClient soapClient = new WebContactServices.WebContactServicesSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                contactDto = soapClient.Get(id);
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            ContactModel contactModel = new ContactModel
            {
                ContactId = contactDto.ContactId,
                Description = contactDto.Description,
                Data = contactDto.Data,
                Deleted = contactDto.Deleted,
                Person = new PersonModel() { PersonId = contactDto.Person.PersonId + 1, Name = contactDto.Person.Name, LastName = contactDto.Person.LastName, BirthDay = contactDto.Person.BirthDay, Deleted = contactDto.Person.Deleted, Gender = new GenderModel() { GenderId = contactDto.Person.Gender.GenderId, Name = contactDto.Person.Gender.Name }, User = new UserModel() }
            };
            return View(contactModel);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            try
            {
                ContactController contactController = new ContactController(logger, _iconfiguration);
                ViewBag.ListContact = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from contact in contactController.ContactListModel
                                select new SelectListItem
                                {
                                    Text = contact.Description,
                                    Value = contact.ContactId.ToString()
                                }
                            )
                            , "Value", "Text");
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactModel contactModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Contact:WebContactService");
                var urlPerson = _iconfiguration.GetValue<string>("WebServices:Person:WebPersonService");
                WebContactServices.WebContactServicesSoapClient soapClient = new WebContactServices.WebContactServicesSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebPersonService.WebPersonServiceSoapClient soapClientPerson = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(urlPerson));
                // TODO: Add insert logic here
                //WebPersonService.PersonDto person = soapClientPerson.GetId(1);

                WebContactServices.ContactDto contact = new WebContactServices.ContactDto()
                {
                    ContactId = contactModel.ContactId,
                    Description = contactModel.Description,
                    Data = contactModel.Data,
                    Deleted = contactModel.Deleted,
                    Person = new WebContactServices.PersonDto() { PersonId = 1, Name = "prueba", LastName = "prueba", BirthDay = DateTime.Now, Deleted = false, Gender = new WebContactServices.GenderDto() { GenderId = 1, Name = "Masculino" }, User = new WebContactServices.UserDto() }
                };
                soapClient.Insert(contact);
                return RedirectToAction(nameof(Index));
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            ContactController contactController = new ContactController(logger, _iconfiguration);
            WebContactServices.ContactDto contactDto = null;
            try
            {
                ViewBag.ListPersonType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from contact in contactController.ContactListModel
                          select new SelectListItem
                          {
                              Text = contact.Description,
                              Value = contact.ContactId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:Contact:WebContactServices");
                WebContactServices.WebContactServicesSoapClient soapClient = new WebContactServices.WebContactServicesSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                contactDto = soapClient.Get(id);
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            ContactModel contactModel = new ContactModel
            {
                ContactId = contactDto.ContactId,
                Description = contactDto.Description,
                Data = contactDto.Data,
                Deleted = contactDto.Deleted,
                Person = new PersonModel() { PersonId = contactDto.Person.PersonId + 1, Name = contactDto.Person.Name, LastName = contactDto.Person.LastName, BirthDay = contactDto.Person.BirthDay, Deleted = contactDto.Person.Deleted, Gender = new GenderModel() { GenderId = contactDto.Person.Gender.GenderId, Name = contactDto.Person.Gender.Name }, User = new UserModel() }
            };

            return View(contactModel);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ContactModel contactModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Contact:WebContactServices");
                // TODO: Add update logic here
                WebContactServices.WebContactServicesSoapClient soapClient = new WebContactServices.WebContactServicesSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebContactServices.ContactDto contact = new WebContactServices.ContactDto()
                {
                    ContactId = contactModel.ContactId,
                    Description = contactModel.Description,
                    Data = contactModel.Data,
                    Deleted = contactModel.Deleted,
                    Person = new WebContactServices.PersonDto() { PersonId = 1, Name = "prueba", LastName = "prueba", BirthDay = DateTime.Now, Deleted = false, Gender = new WebContactServices.GenderDto() { GenderId = 1, Name = "Masculino" }, User = new WebContactServices.UserDto() }
                };
                soapClient.Update(contact);

                return RedirectToAction(nameof(Index));
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}