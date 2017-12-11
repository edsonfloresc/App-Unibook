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
    public class PersonController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private ILogger<PersonController> logger;

        public PersonController(ILogger<PersonController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
        }

        public List<PersonModel> PersonListModel
        {
            get
            {
                WebPersonListService.PersonDto[] persons = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:PersonList:WebPersonListService");
                    WebPersonListService.WebPersonListServiceSoapClient soapClient = new WebPersonListService.WebPersonListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    persons = soapClient.Get();
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

                List<PersonModel> personModel = new List<PersonModel>();
                foreach (var person in persons)
                {
                    personModel.Add(new PersonModel
                    {
                        PersonId = person.PersonId,
                        BirthDay = person.BirthDay,
                        Deleted = person.Deleted,
                        LastName = person.LastName,
                        Name = person.Name,
                        Gender = new GenderModel() { GenderId = person.Gender.GenderId, Name = person.Gender.Name },
                        User = new UserModel()
                    });
                }
                return personModel;
            }
        }
        // GET: Person
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
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Person/Details/5
        public ActionResult Details(long id)
        {
            WebPersonService.PersonDto personDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Person:WebPersonService");
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                personDto = soapClient.Get(id);
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

            PersonModel userModel = new PersonModel
            {
                PersonId = personDto.PersonId,
                BirthDay = personDto.BirthDay,
                Deleted = personDto.Deleted,
                LastName = personDto.LastName,
                Name = personDto.Name,
                Gender = new GenderModel() { GenderId = personDto.Gender.GenderId, Name = personDto.Gender.Name }
            };
            return View(userModel);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            try
            {

                PersonController personController = new PersonController(logger, _iconfiguration);
                ViewBag.ListPerson = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from person in personController.PersonListModel
                                select new SelectListItem
                                {
                                    Text = person.Name,
                                    Value = person.PersonId.ToString()
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

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel personModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Person:WebPersonService");
                var urlGender = _iconfiguration.GetValue<string>("WebServices:Gender:WebGenderService");
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebGenderService.WebGenderServiceSoapClient soapClientRole = new WebGenderService.WebGenderServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(urlGender));
                // TODO: Add insert logic here
                //WebGenderService.GenderDto gender = soapClientRole.GetId(1);



                WebPersonService.PersonDto person = new WebPersonService.PersonDto()
                {
                    PersonId = personModel.PersonId,
                    BirthDay = personModel.BirthDay,
                    Deleted = personModel.Deleted,
                    LastName = personModel.LastName,
                    Name = personModel.Name,
                    Gender = new WebPersonService.GenderDto() { GenderId = 1, Name = "Masculino" }
                };
                soapClient.Insert(person);
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

        // GET: Person/Edit/5
        public ActionResult Edit(long id)
        {
            PersonController personController = new PersonController(logger, _iconfiguration);
            WebPersonService.PersonDto personDto = null;
            try
            {
                ViewBag.ListPersonType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from person in personController.PersonListModel
                          select new SelectListItem
                          {
                              Text = person.Name,
                              Value = person.PersonId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:Person:WebPersonService");
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                personDto = soapClient.Get(id);
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

            PersonModel userModel = new PersonModel
            {
                PersonId = personDto.PersonId,
                BirthDay = personDto.BirthDay,
                Deleted = personDto.Deleted,
                LastName = personDto.LastName,
                Name = personDto.Name,
                Gender = new GenderModel() { GenderId = personDto.Gender.GenderId, Name = personDto.Gender.Name }
            };

            return View(userModel);
        }

        // POST: Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, PersonModel personModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Person:WebPersonService");
                // TODO: Add update logic here
                WebPersonService.WebPersonServiceSoapClient soapClient = new WebPersonService.WebPersonServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebPersonService.PersonDto person = new WebPersonService.PersonDto()
                {
                    PersonId = personModel.PersonId,
                    BirthDay = personModel.BirthDay,
                    Deleted = personModel.Deleted,
                    LastName = personModel.LastName,
                    Name = personModel.Name,
                    Gender = new WebPersonService.GenderDto() { GenderId = personModel.Gender.GenderId, Name = personModel.Gender.Name }
                };
                soapClient.Update(person);

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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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