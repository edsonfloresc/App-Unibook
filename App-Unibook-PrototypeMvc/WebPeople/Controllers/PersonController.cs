using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Univalle.Fie.Sistemas.Unibook.Mvc.WebPeople.Models;
using System.ServiceModel;
using WebPersonListService;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPeople.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Univalle.Fie.Sistemas.Unibook.Mvc.WebPeople.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;

        public PersonController(ILogger<PersonController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
        }

        public static List<PersonModel> PersonListModel
        {
            get
            {
                WebPersonListService.PersonDto[] people = null;
                try
                {
                    //Create instance of SOAP client
                    WebPersonListService.WebPersonListServiceSoapClient soapClient = new WebPersonListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonListService.asmx"));
                    people = soapClient.Get();
                }
                catch  (System.Net.Http.HttpRequestException ex)
                {
                    throw ex;
                }

                List<PersonModel> personModel = new List<PersonModel>();
                foreach (var person in people)
                {
                    personModel.Add(new PersonModel
                    {
                       Id= new Guid(person.Id),
                       Deleted = person.Deleted,
                       FirstName= person.FirstName,
                       LastName = person.LastName,
                       PersonType = new PersonTypeModel() {Id =person.PersonType.Id, Name = person.PersonType.Name}
                    });
                }
                return personModel;
            }
            set { }
        }

        // GET: Persona
        public ActionResult Index()
        {
            List<PersonModel> model = null;
            try
            {
                model = PersonListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                throw ex;
            }

            return View(model);
        }

        // GET: Persona/Details/5
        public ActionResult Details(string id)
        {
            WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonService.asmx"));
            WebPersonService.PersonDto personDto = soapClient.Get(id);
            PersonModel personModel = new PersonModel()
            {
                Id = new Guid(personDto.Id),
                Deleted = personDto.Deleted,
                FirstName = personDto.FirstName,
                LastName = personDto.LastName,
                PersonType = new PersonTypeModel() { Id = personDto.PersonType.Id, Name = personDto.PersonType.Name }
            };
            return View(personModel);
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            ViewBag.ListPersonType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                        (
                            from personType in PersonTypeListController.PersonTypeListModel
                            select new SelectListItem
                            {
                                Text = personType.Name,
                                Value = personType.Id.ToString()
                            }
                        )
                        , "Value", "Text");

            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel personModel)
        {
            try
            {
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonService.asmx"));
                // TODO: Add insert logic here
                WebPersonService.PersonDto person = new WebPersonService.PersonDto()
                {
                    Id = Guid.NewGuid().ToString(),
                    Deleted = false,
                    FirstName = personModel.FirstName,
                    LastName = personModel.LastName,
                    PersonType = new WebPersonService.PersonTypeDto() { Id = personModel.PersonType.Id }
                };
                soapClient.Insert(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(string id)
        {
            ViewBag.ListPersonType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from personType in PersonTypeListController.PersonTypeListModel
                          select new SelectListItem
                          {
                              Text = personType.Name,
                              Value = personType.Id.ToString()
                          }
                      )
                      , "Value", "Text");
            WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonService.asmx"));
            WebPersonService.PersonDto personDto = soapClient.Get(id);
            PersonModel personModel = new PersonModel()
            {
                Id =new Guid(personDto.Id),
                Deleted = personDto.Deleted,
                FirstName = personDto.FirstName,
                LastName = personDto.LastName,
                PersonType = new PersonTypeModel() { Id = personDto.PersonType.Id, Name = personDto.PersonType.Name }
            };

            return View(personModel);
        }

        // POST: Persona/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonModel personModel)
        {
            try
            {
                // TODO: Add update logic here
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonService.asmx"));
                // TODO: Add insert logic here
                WebPersonService.PersonDto person = new WebPersonService.PersonDto()
                {
                    Id = personModel.Id.ToString(),
                    Deleted = personModel.Deleted,
                    FirstName = personModel.FirstName,
                    LastName = personModel.LastName,
                    PersonType = new WebPersonService.PersonTypeDto() { Id = personModel.PersonType.Id }
                };
                soapClient.Update(person);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(string id)
        {
            WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonService.asmx"));
            WebPersonService.PersonDto personDto = soapClient.Get(id);
            PersonModel personModel = new PersonModel()
            {
                Id = new Guid(personDto.Id),
                Deleted = personDto.Deleted,
                FirstName = personDto.FirstName,
                LastName = personDto.LastName,
                PersonType = new PersonTypeModel() { Id = personDto.PersonType.Id, Name = personDto.PersonType.Name }
            };
            return View(personModel);
        }

        // POST: Persona/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonService.asmx"));
                soapClient.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}