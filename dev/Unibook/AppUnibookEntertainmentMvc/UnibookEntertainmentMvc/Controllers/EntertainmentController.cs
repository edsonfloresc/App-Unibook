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
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace UnibookEntertainmentMvc.Controllers
{
    public class EntertainmentController : Controller
    {

        private readonly IFileProvider _fileProvider;
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private readonly IStringLocalizer<EntertainmentController> _localizer;

        public EntertainmentController(ILogger<EntertainmentController> logger, IConfiguration iconfiguration, IStringLocalizer<EntertainmentController> localizer, IFileProvider fileProvider)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
            _localizer = localizer;
            _fileProvider = fileProvider;
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
        public ActionResult Details(long id)
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
                entertainment = soapClient.GetDto(id);
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
            EntertainmentModel entertainmentModel = new EntertainmentModel
            {
                EntertainmentId = entertainment.EntertainmentId,
                Title = entertainment.Title,
                DateHour = entertainment.DateHour,
                PlaceAddress = entertainment.PlaceAddress,
                Details = entertainment.Details,
                Discontinued = entertainment.Discontinued,
                Deleted = entertainment.Deleted,
                Category = new CategoryModel() { CategoryId = 1, Description = "Ferias", Deleted = false },
              //  User = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.UserModel() { UserId = 5, Email = "juan@gmail.com", Deleted = false, Role = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.RoleModel() { RoleId = 5, Name = "gerente", Deleted = false }, Person = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.PersonModel() { PersonId = 6, Name = "juan", LastName = "Perez", BirthDay = DateTime.Now } }


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
                    CategoryEnter = new WebEntertainmentService.CategoryEnterDto() { CategoryId = entertainment.Category.CategoryId },
                    Users = new WebEntertainmentService.UserDto() { UserId = 5 }
                    

                };

                soapClient.Insert(entertainmentModel);

              
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
        public ActionResult Edit(long id)
        {

            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            WebEntertainmentService.EntertainmentDto entertainmentDto = null;
            try
            {


                //CategoryListController categoryController = new CategoryListController(_logger, _iconfiguration);

                //ViewBag.listCategory = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                //            (
                //                from category in categoryController.CategoryListModel
                //                select new SelectListItem
                //                {
                //                    Text = category.Description,
                //                    Value = category.CategoryId.ToString()
                //                }
                //            )
                //            , "Value", "Text");



                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentService");

                //  Create instance of SOAP client
                WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                entertainmentDto = soapClient.GetDto(id);
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
            EntertainmentModel entertainment = new EntertainmentModel()
            {
                EntertainmentId = entertainmentDto.EntertainmentId,
                Title = entertainmentDto.Title,
                DateHour = entertainmentDto.DateHour,
                PlaceAddress = entertainmentDto.PlaceAddress,
                Details = entertainmentDto.Details,
                Discontinued = entertainmentDto.Discontinued,
                Deleted = entertainmentDto.Deleted
               // Category = new CategoryModel() { CategoryId = entertainmentDto.CategoryEnter.CategoryId, Description= entertainmentDto.CategoryEnter.Description, Deleted= entertainmentDto.CategoryEnter.Deleted}
                //User = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.UserModel() { UserId = entertainmentDto.Users.UserId, Email = entertainmentDto.Users.Email, Deleted = entertainmentDto.Users.Deleted, Role = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.RoleModel() { RoleId = entertainmentDto.Users.Role.RoleId, Name = entertainmentDto.Users.Role.Name, Deleted = entertainmentDto.Users.Role.Deleted }, Person = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.PersonModel() { PersonId = entertainmentDto.Users.Person.PersonId, Name = entertainmentDto.Users.Person.Name, LastName = entertainmentDto.Users.Person.LastName, BirthDay = entertainmentDto.Users.Person.BirthDay } }


            };

            return View(entertainment);


        }

        // POST: Entertainment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, EntertainmentModel entertainmentDto)
        {
            try
            {
                // TODO: Add update logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentService");
                //WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebEntertainmentService.EntertainmentDto entertainment = new WebEntertainmentService.EntertainmentDto()
                {
                    EntertainmentId = entertainmentDto.EntertainmentId,
                    Title = entertainmentDto.Title,
                    DateHour = entertainmentDto.DateHour,
                    PlaceAddress = entertainmentDto.PlaceAddress,
                    Details = entertainmentDto.Details,
                    Discontinued = entertainmentDto.Discontinued,
                    Deleted = entertainmentDto.Deleted
                //   CategoryEnter = new WebEntertainmentService.CategoryEnterDto() { CategoryId = entertainmentDto.Category.CategoryId, Description = entertainmentDto.Category.Description, Deleted = entertainmentDto.Category.Deleted }
                    //Users = new WebEntertainmentService.UserDto() { UserId = entertainmentDto.User.UserId, Email = entertainmentDto.User.Email, Deleted = entertainmentDto.User.Deleted, Role =new WebEntertainmentService.RoleDto () { RoleId = entertainmentDto.User.Role.RoleId, Name = entertainmentDto.User.Role.Name, Deleted = entertainmentDto.User.Role.Deleted }, Person = new WebEntertainmentService.PersonDto() { PersonId = entertainmentDto.User.Person.PersonId, Name = entertainmentDto.User.Person.Name, LastName = entertainmentDto.User.Person.LastName, BirthDay = entertainmentDto.User.Person.BirthDay } }



                };
                soapClient.Update(entertainment);
                //soapClient.Update(category);
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

        // GET: Entertainment/Delete/5
        public ActionResult Delete(long id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentService");
            EntertainmentModel entertainmentModel = null;
            try
            {
                // TODO: Add update logic here
                WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebEntertainmentService.EntertainmentDto entertainment = soapClient.GetDto(id);
                entertainmentModel = new EntertainmentModel()
                {
                    EntertainmentId = entertainment.EntertainmentId,
                    Title = entertainment.Title,
                    DateHour = entertainment.DateHour,
                    PlaceAddress = entertainment.PlaceAddress,
                    Details = entertainment.Details,
                    Discontinued = entertainment.Discontinued,
                    Deleted = entertainment.Deleted
                    //Category = new CategoryModel() { CategoryId = entertainment.CategoryEnter.CategoryId, Description = entertainment.CategoryEnter.Description, Deleted = entertainment.CategoryEnter.Deleted }
                    //Users = new WebEntertainmentService.UserDto() { UserId = entertainmentDto.User.UserId, Email = entertainmentDto.User.Email, Deleted = entertainmentDto.User.Deleted, Role = new WebEntertainmentService.RoleDto() { RoleId = entertainmentDto.User.Role.RoleId, Name = entertainmentDto.User.Role.Name, Deleted = entertainmentDto.User.Role.Deleted }, Person = new WebEntertainmentService.PersonDto() { PersonId = entertainmentDto.User.Person.PersonId, Name = entertainmentDto.User.Person.Name, LastName = entertainmentDto.User.Person.LastName, BirthDay = entertainmentDto.User.Person.BirthDay } }


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


            return View(entertainmentModel);
        }

        // POST: Entertainment/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebEntertainmentService");
                WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                soapClient.DeleteAsync(id);

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


        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot",
                        file.GetFilename());

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return RedirectToAction("Files");
        }
    }
}
