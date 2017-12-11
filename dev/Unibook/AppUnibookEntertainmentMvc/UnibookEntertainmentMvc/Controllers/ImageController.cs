using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System.ServiceModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UnibookEntertainmentMvc.Controllers
{
    public class ImageController : Controller
    {


        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private readonly IStringLocalizer<ImageController> _localizer;

        public ImageController(ILogger<ImageController> logger, IConfiguration iconfiguration, IStringLocalizer<ImageController> localizer)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
            _localizer = localizer;
        }


        public List<ImageModel> ImageListModel
        {
            get
            {
                WebImageListService.ImageEnterDto[] imageList = null;

                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageListService");

                    //  Create instance of SOAP client
                    WebImageListService.WebImageListServiceSoapClient soapClient = new WebImageListService.WebImageListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    imageList = soapClient.Get();
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
                List<ImageModel> _imageListModel = new List<ImageModel>();
                foreach (var item in imageList)
                {
                    _imageListModel.Add(new ImageModel
                    {
                        ImageId = item.ImageId,
                        PathImage= item.PathImage,
                        Deleted= item.Deleted
                      // Entertainment= new EntertainmentModel() { EntertainmentId= item.Entertainment.EntertainmentId, Title= item.Entertainment.Title, DateHour= item.Entertainment.DateHour, Details= item.Entertainment.Details, PlaceAddress= item.Entertainment.PlaceAddress, Deleted= item.Entertainment.Deleted, Discontinued= item.Entertainment.Discontinued, Category= new CategoryModel() { CategoryId= item.Entertainment.CategoryEnter.CategoryId, Description= item.Entertainment.CategoryEnter.Description, Deleted= item.Entertainment.CategoryEnter.Deleted}, User = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.UserModel() { UserId = item.Entertainment.Users.UserId, Email = item.Entertainment.Users.Email, Deleted = item.Entertainment.Users.Deleted, Role = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.RoleModel() { RoleId = item.Entertainment.Users.Role.RoleId, Name = item.Entertainment.Users.Role.Name, Deleted = item.Entertainment.Users.Role.Deleted }, Person = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.PersonModel() { PersonId = item.Entertainment.Users.Person.PersonId, Name = item.Entertainment.Users.Person.Name, LastName = item.Entertainment.Users.Person.LastName, BirthDay = item.Entertainment.Users.Person.BirthDay } } }
                    });
                }
                return _imageListModel;
            }
        }



        // GET: Image
        public ActionResult Index()
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Create"] = _localizer["Create"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            List<ImageModel> list = null;
            try
            {
                list = ImageListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {

                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(list);
        }

        // GET: Image/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];


            WebImageService.ImageEnterDto image = null;
           

            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageService");

                //  Create instance of SOAP client
                WebImageService.WebImageServiceSoapClient soapClient = new WebImageService.WebImageServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                image = soapClient.Get(id);
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


            ImageModel imageModel = new ImageModel
            {
                ImageId= image.ImageId,
                PathImage= image.PathImage,
                Deleted= image.Deleted
              //  Entertainment = new EntertainmentModel() { EntertainmentId = image.Entertainment.EntertainmentId, Title = image.Entertainment.Title, DateHour = image.Entertainment.DateHour, Details = image.Entertainment.Details, PlaceAddress = image.Entertainment.PlaceAddress, Deleted = image.Entertainment.Deleted, Discontinued = image.Entertainment.Discontinued, Category = new CategoryModel() { CategoryId = image.Entertainment.CategoryEnter.CategoryId, Description = image.Entertainment.CategoryEnter.Description, Deleted = image.Entertainment.CategoryEnter.Deleted }, User = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.UserModel() { UserId = image.Entertainment.Users.UserId, Email = image.Entertainment.Users.Email, Deleted = image.Entertainment.Users.Deleted, Role = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.RoleModel() { RoleId = image.Entertainment.Users.Role.RoleId, Name = image.Entertainment.Users.Role.Name, Deleted = image.Entertainment.Users.Role.Deleted }, Person = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.PersonModel() { PersonId = image.Entertainment.Users.Person.PersonId, Name = image.Entertainment.Users.Person.Name, LastName = image.Entertainment.Users.Person.LastName, BirthDay = image.Entertainment.Users.Person.BirthDay } } }


            };

            return View(imageModel);
        }

        // GET: Image/Create
        public ActionResult Create()
        {
            try
            {

                EntertainmentListController entertainmentController = new EntertainmentListController(_logger, _iconfiguration);

                ViewBag.listEntertainment = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from entertainment in entertainmentController.EntertainmentListModel
                                select new SelectListItem
                                {
                                    Text = entertainment.Title,
                                    Value = entertainment.EntertainmentId.ToString()
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

        // POST: Image/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ImageModel image)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageService");

                WebImageService.WebImageServiceSoapClient soapClient = new WebImageService.WebImageServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebImageService.ImageEnterDto imageModel = new WebImageService.ImageEnterDto
                {
                    PathImage= image.PathImage,
                    Deleted= image.Deleted,
                    Entertainment= new WebImageService.EntertainmentDto() { EntertainmentId=1}

                };
              

               soapClient.Insert(imageModel);


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

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

         
            WebImageService.ImageEnterDto image = null;
            try
            {




                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageService");

                //  Create instance of SOAP client
                WebImageService.WebImageServiceSoapClient soapClient = new WebImageService.WebImageServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
             image = soapClient.Get(id);
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
            ImageModel imageModel = new ImageModel
            {
                ImageId= image.ImageId,
                PathImage = image.PathImage,
                Deleted = image.Deleted,
               // Entertainment = new WebImageService.EntertainmentDto() { EntertainmentId = 1 }
            };
          

            return View(imageModel);
        }

        // POST: Image/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ImageModel image)
        {
            try
            {
                // TODO: Add update logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageService");
                //WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebImageService.WebImageServiceSoapClient soapClient = new WebImageService.WebImageServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));

                WebImageService.ImageEnterDto imageModel = new WebImageService.ImageEnterDto
                {
                    ImageId = image.ImageId,
                    PathImage = image.PathImage,
                    Deleted = image.Deleted,
                    Entertainment = new WebImageService.EntertainmentDto() { EntertainmentId = 1 }
                };

               soapClient.Update(imageModel);
                
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

        // GET: Image/Delete/5
        public ActionResult Delete(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageService");
            ImageModel imageModel = null;

            try
            {
                // TODO: Add update logic here
                WebImageService.WebImageServiceSoapClient soapClient = new WebImageService.WebImageServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                 WebImageService.ImageEnterDto image = soapClient.Get(id);

                imageModel = new ImageModel
                {
                    PathImage = image.PathImage,
                    Deleted = image.Deleted,
                    // Entertainment = new WebImageService.EntertainmentDto() { EntertainmentId = 1 }
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


            return View(imageModel);
        }

        // POST: Image/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebImageService");
                //WebEntertainmentService.WebEntertainmentServiceSoapClient soapClient = new WebEntertainmentService.WebEntertainmentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebImageService.WebImageServiceSoapClient soapClient = new WebImageService.WebImageServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));

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
    }
}