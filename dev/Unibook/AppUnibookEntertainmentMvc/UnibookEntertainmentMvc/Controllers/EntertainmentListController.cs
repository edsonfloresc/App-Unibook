using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Configuration;
using Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models;
using System.ServiceModel;
using Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UnibookEntertainmentMvc.Controllers
{
    public class EntertainmentListController : Controller
    {

        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
     

        public EntertainmentListController(ILogger logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
          
        }


        public List<EntertainmentModel> EntertainmentListModel
        {
            get
            {
                WebEntertainmentListService.EntertainmentDto[] entertainmentList = null;

                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentListService");

                    //  Create instance of SOAP client
                    WebEntertainmentListService.WebEntertainmentListServiceSoapClient soapClient = new WebEntertainmentListService.WebEntertainmentListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    entertainmentList = soapClient.Get();
                    //  _categoryListModel = new List<CategoryModel>();
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
                List<EntertainmentModel> _entertainmentListModel = new List<EntertainmentModel>();
                foreach (var item in entertainmentList)
                {
                    _entertainmentListModel.Add(new EntertainmentModel
                    {
                        EntertainmentId = item.EntertainmentId,
                        Title = item.Title,
                        PlaceAddress = item.PlaceAddress,
                        DateHour = item.DateHour,
                        Details = item.Details,
                        Deleted = item.Deleted,
                        Discontinued = item.Discontinued,
                        //Category = new CategoryModel() { CategoryId = 1, Description = "descripcion corrupa", Deleted = false }
                        Category = new CategoryModel() { CategoryId = item.CategoryEnter.CategoryId, Description = item.CategoryEnter.Description, Deleted = item.CategoryEnter.Deleted }
                        //   User = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.UserModel() { UserId = item.Users.UserId, Email = item.Users.Email, Deleted = item.Users.Deleted, Role = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.RoleModel() { RoleId = item.Users.Role.RoleId, Name = item.Users.Role.Name, Deleted = item.Users.Role.Deleted }, Person = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.PersonModel() { PersonId = item.Users.Person.PersonId, Name = item.Users.Person.Name, LastName = item.Users.Person.LastName, BirthDay = item.Users.Person.BirthDay } }

                    });
                }
                return _entertainmentListModel;
            }
        }

        // GET: EntertainmentList
        public ActionResult Index()
        {
            return View();
        }

        // GET: EntertainmentList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EntertainmentList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntertainmentList/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EntertainmentList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EntertainmentList/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EntertainmentList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EntertainmentList/Delete/5
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