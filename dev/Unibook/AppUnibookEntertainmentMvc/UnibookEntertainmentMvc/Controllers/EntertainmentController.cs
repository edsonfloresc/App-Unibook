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
    public class EntertainmentController : Controller
    {


        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private readonly IStringLocalizer<EntertainmentController> _localizer;

        public EntertainmentController(ILogger<EntertainmentController> logger, IConfiguration iconfiguration, IStringLocalizer<EntertainmentController> localizer)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
            _localizer = localizer;
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
                        Category = new CategoryModel() { CategoryId = item.CategoryEnter.CategoryId, Description = item.CategoryEnter.Description, Deleted = item.CategoryEnter.Deleted },
                      // User = new UserModel() { UserId = item.User.UserId, Email = item.User.Email, Password=item.User.Password,   Deleted = item.User.Deleted, Role = new RoleModel() { RoleId = item.User.Role.RoleId, Name = item.User.Role.Name, Deleted = item.User.Role.Deleted }, Person = new PersonModel() { PersonId = item.User.Person.PersonId, Name = item.User.Person.Name, LastName = item.User.Person.LastName, BirthDay = item.User.Person.Birthday, Gender = new GenderModel() { GenderId = item.User.Person.Gender.GenderId, Name = item.User.Person.Gender.Name } } }

                    });
                }
                return _entertainmentListModel;
            }
        }


        // GET: Entertainment
        public ActionResult Index()
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Create"] = _localizer["Create"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            List<EntertainmentModel> list = null;
            try
            {
                list = EntertainmentListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {

                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(list);
        }

        // GET: Entertainment/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];


            WebEntertainmentService.EntertainmentDto entertainment = null;
           // WebCategoryService.CategoryEnterDto category = null;

            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentService");

                //  Create instance of SOAP client
                WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                entertainment = soapClient.Get(id);
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
            EntertainmentModel entertainmentModel = new EntertainmentModel()
            {
                EntertainmentId= entertainment.EntertainmentId,
                Title= entertainment.Title,
             //   DateHour= entertainment.DateHour,
                PlaceAddress= entertainment.PlaceAddress,
                Details= entertainment.Details,
                Discontinued= entertainment.Discontinued,
                Deleted= entertainment.Deleted,
               // Category = new CategoryModel() { CategoryId = entertainment.CategoryEnter.CategoryId, Description = entertainment.CategoryEnter.Description, Deleted = entertainment.CategoryEnter.Deleted }


            };

            return View(entertainmentModel);
        }

        // GET: Entertainment/Create
        public ActionResult Create()
        {
            try
            {
               
                CategoryListController categoryController = new CategoryListController(_logger, _iconfiguration);
                ViewBag.listCategory = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from category in categoryController.CategoryListModel
                                select new SelectListItem
                                {
                                    Text = category.Description,
                                    Value = category.CategoryId.ToString()
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

        // POST: Entertainment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntertainmentModel entertainment)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentService");

                WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebEntertainmentService.EntertainmentDto entertainmentModel = new WebEntertainmentService.EntertainmentDto()
                {
                   
                    Title = entertainment.Title,
                    DateHour = entertainment.DateHour,
                    PlaceAddress = entertainment.PlaceAddress,
                    Details = entertainment.Details,
                    Discontinued = false,
                    Deleted = false,
                    CategoryEnter = new WebEntertainmentService.CategoryEnterDto() { CategoryId= entertainment.Category.CategoryId}


                };
                soapClient.InsertAsync(entertainmentModel);
                
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

        // GET: Entertainment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Entertainment/Edit/5
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

        // GET: Entertainment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Entertainment/Delete/5
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