using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System.ServiceModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppUnibookRegisterMvc.Controllers
{
    public class RoleController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        //private readonly IStringLocalizer<RoleController> _localizer;
        private ILogger<RoleController> logger;

        public RoleController(ILogger<RoleController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
            //_localizer = localizer;
        }

        public List<RoleModel> RoleModel
        {
            get
            {
                WebRoleService.RoleDto roles = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
                    //Create instance of SOAP client
                    WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    roles = soapClient.Get();
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

                RoleModel role = new RoleModel
                {
                    RoleId = roles.RoleId,
                    Deleted = roles.Deleted,
                    Name = roles.Name,
                };
                List<RoleModel> list = new List<RoleModel>();
                list.Add(role);
                return list;
            }
        }

        // GET: Role
        public ActionResult Index()
        {
            //ViewData["Index"] = _localizer["Index"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["Delete"] = _localizer["Delete"];

            List<RoleModel> model = null;
            try
            {
                model = RoleModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Role/Details/5
        public ActionResult Details(short id)
        {
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["BackToList"] = _localizer["BackToList"];

            WebRoleService.RoleDto roleDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
                WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                roleDto = soapClient.GetId(id);
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

            RoleModel roleModel = new RoleModel()
            {
                RoleId = roleDto.RoleId,
                Deleted = roleDto.Deleted,
                Name = roleDto.Name,
            };
            return View(roleModel);
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            try
            {

                RoleController roleController = new RoleController(logger, _iconfiguration);
                ViewBag.ListRole = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from role in roleController.RoleModel
                                select new SelectListItem
                                {
                                    Text = role.Name,
                                    Value = role.RoleId.ToString()
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

        // POST: Role/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoleModel roleModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");

                WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebRoleService.RoleDto role = new WebRoleService.RoleDto()
                {
                    Deleted = false,
                    Name = roleModel.Name,
                };
                soapClient.Insert(role);
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

        // GET: Role/Edit/5
        public ActionResult Edit(short id)
        {
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Save"] = _localizer["Save"];
            //ViewData["BackToList"] = _localizer["BackToList"];

            RoleController roleController = new RoleController(logger, _iconfiguration);
            WebRoleService.RoleDto roleDto = null;
            try
            {
                ViewBag.ListRole = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from role in roleController.RoleModel
                          select new SelectListItem
                          {
                              Text = role.Name,
                              Value = role.RoleId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
                WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                roleDto = soapClient.GetId(id);
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

            RoleModel roleModel = new RoleModel()
            {
                RoleId = roleDto.RoleId,
                Deleted = roleDto.Deleted,
                Name = roleDto.Name
            };

            return View(roleModel);
        }

        // POST: Role/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(short id, RoleModel roleModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
                // TODO: Add update logic here
                WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebRoleService.RoleDto role = new WebRoleService.RoleDto()
                {
                    RoleId = roleModel.RoleId,
                    Deleted = roleModel.Deleted,
                    Name = roleModel.Name,
                };
                soapClient.Update(role);

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

        // GET: Role/Delete/5
        public ActionResult Delete(short id)
        {
            //ViewData["Person"] = _localizer["Person"];
            //ViewData["Delete"] = _localizer["Delete"];
            //ViewData["BackToList"] = _localizer["BackToList"];
            //ViewData["DeletedMessage"] = _localizer["DeletedMessage"];

            var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
            RoleModel roleModel = null;
            try
            {
                WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebRoleService.RoleDto roleDto = soapClient.GetId(id);
                roleModel = new RoleModel()
                {
                    RoleId = roleDto.RoleId,
                    Deleted = roleDto.Deleted,
                    Name = roleDto.Name
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

            return View(roleModel);
        }

        // POST: Role/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(short id, IFormCollection collection)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
                // TODO: Add delete logic here
                WebRoleService.WebRoleServiceSoapClient soapClient = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
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