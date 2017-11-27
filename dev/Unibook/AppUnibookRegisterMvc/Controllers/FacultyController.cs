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
    public class FacultyController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        //private readonly IStringLocalizer<RoleController> _localizer;
        private ILogger<FacultyController> logger;

        public FacultyController(ILogger<FacultyController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
            //_localizer = localizer;
        }

        public List<FacultyModel> FacultyModel
        {
            get
            {
                WebFacultyService.FacultyDto facultys = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");
                    //Create instance of SOAP client
                    WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    facultys = soapClient.Get();
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

                FacultyModel faculty = new FacultyModel
                {
                    FacultyId = facultys.FacultyId,
                    Deleted = facultys.Deleted,
                    Name = facultys.Name,
                };
                List<FacultyModel> list = new List<FacultyModel>();
                list.Add(faculty);
                return list;
            }
        }
        // GET: Faculty
        public ActionResult Index()
        {
            //ViewData["Index"] = _localizer["Index"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["Delete"] = _localizer["Delete"];

            List<FacultyModel> model = null;
            try
            {
                model = FacultyModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Faculty/Details/5
        public ActionResult Details(short id)
        {
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["BackToList"] = _localizer["BackToList"];

            WebFacultyService.FacultyDto facultyDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");
                WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                facultyDto = soapClient.GetId(id);
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

            FacultyModel facultyModel = new FacultyModel()
            {
                FacultyId = facultyDto.FacultyId,
                Deleted = facultyDto.Deleted,
                Name = facultyDto.Name,
            };
            return View(facultyModel);
        }

        // GET: Faculty/Create
        public ActionResult Create()
        {
            try
            {

                FacultyController facultyController = new FacultyController(logger, _iconfiguration);
                ViewBag.ListFaculty = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from faculty in facultyController.FacultyModel
                                select new SelectListItem
                                {
                                    Text = faculty.Name,
                                    Value = faculty.FacultyId.ToString()
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

        // POST: Faculty/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FacultyModel facultyModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");

                WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebFacultyService.FacultyDto faculty = new WebFacultyService.FacultyDto()
                {
                    Deleted = false,
                    Name = facultyModel.Name,
                };
                soapClient.Insert(faculty);
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

        // GET: Faculty/Edit/5
        public ActionResult Edit(short id)
        {
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Save"] = _localizer["Save"];
            //ViewData["BackToList"] = _localizer["BackToList"];

            FacultyController facultyController = new FacultyController(logger, _iconfiguration);
            WebFacultyService.FacultyDto facultyDto = null;
            try
            {
                ViewBag.ListFaculty = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from faculty in facultyController.FacultyModel
                          select new SelectListItem
                          {
                              Text = faculty.Name,
                              Value = faculty.FacultyId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");
                WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                facultyDto = soapClient.GetId(id);
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

            FacultyModel facultyModel = new FacultyModel()
            {
                FacultyId = facultyDto.FacultyId,
                Deleted = facultyDto.Deleted,
                Name = facultyDto.Name
            };

            return View(facultyModel);
        }

        // POST: Faculty/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(short id, FacultyModel facultyModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");
                // TODO: Add update logic here
                WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebFacultyService.FacultyDto faculty = new WebFacultyService.FacultyDto()
                {
                    FacultyId = facultyModel.FacultyId,
                    Deleted = facultyModel.Deleted,
                    Name = facultyModel.Name,
                };
                soapClient.Update(faculty);

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

        // GET: Faculty/Delete/5
        public ActionResult Delete(short id)
        {
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Delete"] = _localizer["Delete"];
            //ViewData["BackToList"] = _localizer["BackToList"];
            //ViewData["DeletedMessage"] = _localizer["DeletedMessage"];

            var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");
            FacultyModel facultyModel = null;
            try
            {
                WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebFacultyService.FacultyDto facultyDto = soapClient.GetId(id);
                facultyModel = new FacultyModel()
                {
                    FacultyId = facultyDto.FacultyId,
                    Deleted = facultyDto.Deleted,
                    Name = facultyDto.Name
                };
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

            return View(facultyModel);
        }

        // POST: Faculty/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(short id, IFormCollection collection)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Faculty:WebFacultyService");
                // TODO: Add delete logic here
                WebFacultyService.WebFacultyServiceSoapClient soapClient = new WebFacultyService.WebFacultyServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                //soapClient.Delete(id);
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
    }
}