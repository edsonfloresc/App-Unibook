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
using WebUserListService;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppUnibookRegisterMvc.Controllers
{
    
    public class UserController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        //private readonly IStringLocalizer<RoleController> _localizer;
        private ILogger<UserController> logger;

        public UserController(ILogger<UserController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
            //_localizer = localizer;
        }

        public List<UserModel> UserListModel
        {
            get
            {
                WebUserListService.UserDto[] users = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:UserList:WebUserListService");
                    //Create instance of SOAP client
                    WebUserListService.WebUserListServiceSoapClient soapClient = new WebUserListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    users = soapClient.Get();
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

                List<UserModel> userModel = new List<UserModel>();
                foreach (var user in users)
                {
                    userModel.Add(new UserModel
                    {
                        UserId = user.UserId,
                        Deleted = user.Deleted,
                        Email = user.Email,
                        Password = user.Password,
                        Role = new RoleModel() { RoleId = user.Role.RoleId, Name = user.Role.Name, Deleted = user.Role.Deleted },
                        Person = new PersonModel() { PersonId = user.Person.PersonId+1, Name = user.Person.Name, LastName = user.Person.LastName, BirthDay = user.Person.BirthDay, Deleted = user.Person.Deleted, Gender = new GenderModel() { GenderId = user.Person.Gender.GenderId, Name = user.Person.Gender.Name }, User = new UserModel() }
                    });
                }
                return userModel;
            }
        }

        // GET: User
        public ActionResult Index()
        {
            //ViewData["Index"] = _localizer["Index"];
            //ViewData["Edit"] = _localizer["Edit"];
            //ViewData["Details"] = _localizer["Details"];
            //ViewData["Delete"] = _localizer["Delete"];

            List<UserModel> model = null;
            try
            {
                model = UserListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: User/Details/5
        public ActionResult Details(long id)
        {
            WebUserService.UserDto userDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:User:WebUserService");
                WebUserService.WebUserServiceSoapClient soapClient = new WebUserService.WebUserServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                userDto = soapClient.Get(id);
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

            UserModel userModel = new UserModel
            {
                UserId = userDto.UserId,
                Deleted = userDto.Deleted,
                Email = userDto.Email,
                Password = userDto.Password,
                Role = new RoleModel() { RoleId = userDto.Role.RoleId, Name = userDto.Role.Name, Deleted = userDto.Role.Deleted },
                Person = new PersonModel() { PersonId = userDto.Person.PersonId + 1, Name = userDto.Person.Name, LastName = userDto.Person.LastName, BirthDay = userDto.Person.BirthDay, Deleted = userDto.Person.Deleted, Gender = new GenderModel() { GenderId = userDto.Person.Gender.GenderId, Name = userDto.Person.Gender.Name }, User = new UserModel() }
            };
            return View(userModel);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            try
            {

                UserController userController = new UserController(logger, _iconfiguration);
                ViewBag.ListUser= new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from user in userController.UserListModel
                                select new SelectListItem
                                {
                                    Text = user.Email,
                                    Value = user.UserId.ToString()
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

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel userModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:User:WebUserService");
                var urlRole = _iconfiguration.GetValue<string>("WebServices:Role:WebRoleService");
                WebUserService.WebUserServiceSoapClient soapClient = new WebUserService.WebUserServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebRoleService.WebRoleServiceSoapClient soapClientRole = new WebRoleService.WebRoleServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(urlRole));
                // TODO: Add insert logic here
                WebRoleService.RoleDto role = soapClientRole.GetId(1);



                WebUserService.UserDto user = new WebUserService.UserDto()
                {
                    UserId = userModel.UserId,
                    Deleted = false,
                    Email = userModel.Email,
                    Password = userModel.Password,
                    Role = new WebUserService.RoleDto() { RoleId = role.RoleId, Name = role.Name, Deleted = role.Deleted},
                    //Person = new WebUserService.PersonDto() { PersonId = 5 }
                };
                soapClient.Insert(user);
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

        // GET: User/Edit/5
        public ActionResult Edit(long id)
        {
            UserController userController = new UserController(logger, _iconfiguration);
            WebUserService.UserDto userDto = null;
            try
            {
                ViewBag.ListPersonType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from user in userController.UserListModel
                          select new SelectListItem
                          {
                              Text = user.Email,
                              Value = user.UserId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:User:WebUserService");
                WebUserService.WebUserServiceSoapClient soapClient = new WebUserService.WebUserServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                userDto = soapClient.Get(id);
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

            UserModel userModel = new UserModel
            {
                UserId = userDto.UserId,
                Deleted = userDto.Deleted,
                Email = userDto.Email,
                Password = userDto.Password,
                Role = new RoleModel() { RoleId = userDto.Role.RoleId, Name = userDto.Role.Name, Deleted = userDto.Role.Deleted },
                Person = new PersonModel() { PersonId = userDto.Person.PersonId + 1, Name = userDto.Person.Name, LastName = userDto.Person.LastName, BirthDay = userDto.Person.BirthDay, Deleted = userDto.Person.Deleted, Gender = new GenderModel() { GenderId = userDto.Person.Gender.GenderId, Name = userDto.Person.Gender.Name }, User = new UserModel() }
            };

            return View(userModel);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, UserModel userModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:User:WebUserService");
                // TODO: Add update logic here
                WebUserService.WebUserServiceSoapClient soapClient = new WebUserService.WebUserServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebUserService.UserDto user = new WebUserService.UserDto()
                {
                    UserId = userModel.UserId,
                    Deleted = userModel.Deleted,
                    Email = userModel.Email,
                    Password = userModel.Password,
                    Role = new WebUserService.RoleDto() { RoleId = userModel.Role.RoleId, Name = userModel.Role.Name, Deleted = userModel.Role.Deleted },
                    Person = new WebUserService.PersonDto() { PersonId = userModel.Person.PersonId + 1, Name = userModel.Person.Name, LastName = userModel.Person.LastName, BirthDay = userModel.Person.BirthDay, Deleted = userModel.Person.Deleted, Gender = new WebUserService.GenderDto() { GenderId = userModel.Person.Gender.GenderId, Name = userModel.Person.Gender.Name }, User = new WebUserService.UserDto() }
                };
                soapClient.Update(user);

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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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