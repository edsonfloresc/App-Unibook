using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models;
using System.ServiceModel;

namespace AppUnibookRegisterMvc.Controllers
{
    public class GenderController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        //private readonly IStringLocalizer<RoleController> _localizer;
        private ILogger<GenderController> logger;

        public GenderController(ILogger<GenderController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
            //_localizer = localizer;
        }
        public List<GenderModel> GenderListModel
        {
            get
            {
                WebGenderListService.GenderDto[] genders = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:GenderList:WebGenderListService");
                    //Create instance of SOAP client
                    WebGenderListService.WebGenderListServiceSoapClient soapClient = new WebGenderListService.WebGenderListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    genders = soapClient.Get();
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

                List<GenderModel> genderModel = new List<GenderModel>();
                foreach (var gender in genders)
                {
                    genderModel.Add(new GenderModel
                    {
                        GenderId = gender.GenderId,
                        Name = gender.Name,
                    });
                }
                return genderModel;
            }
        }
        // GET: Gender
        public ActionResult Index()
        {
            //ViewData["Index"] = _localizer["Index"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["Delete"] = _localizer["Delete"];

            List<GenderModel> model = null;
            try
            {
                model = GenderListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Gender/Details/5
        public ActionResult Details(short id)
        {
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["BackToList"] = _localizer["BackToList"];

            WebGenderService.GenderDto genderDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Gender:WebGenderService");
                WebGenderService.WebGenderServiceSoapClient soapClient = new WebGenderService.WebGenderServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                genderDto = soapClient.GetId(id);
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

            GenderModel genderModel = new GenderModel()
            {
                GenderId = genderDto.GenderId,
                Name = genderDto.Name,
            };
            return View(genderModel);
        }

        // GET: Gender/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gender/Create
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

        // GET: Gender/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gender/Edit/5
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

        // GET: Gender/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gender/Delete/5
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