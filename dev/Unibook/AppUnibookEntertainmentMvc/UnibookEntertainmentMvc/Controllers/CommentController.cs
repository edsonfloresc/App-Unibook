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
    public class CommentController : Controller
    {


       
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private readonly IStringLocalizer<CommentController> _localizer;

        public CommentController(ILogger<CommentController> logger, IConfiguration iconfiguration, IStringLocalizer<CommentController> localizer)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
            _localizer = localizer;
           
        }


        public List<CommentModel> CommentListModel
        {
            get
            {
                WebCommentListService.CommentEnterDto[] commentList = null;

                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentListService");

                    //  Create instance of SOAP client
                    WebCommentListService.WebCommentListServiceSoapClient soapClient = new WebCommentListService.WebCommentListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                   commentList = soapClient.Get();
                  
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

                List<CommentModel> _commentListModel = new List<CommentModel>();
                foreach (var item in commentList)
                {
                    _commentListModel.Add(new CommentModel
                    {
                        CommentId = item.CommentId,
                        CommentText = item.CommentText,
                        DateHour = item.DateHour,
                        Deleted = item.Deleted
                        //Entertainment= new EntertainmentModel() { },
                        //Category = new CategoryModel() { CategoryId = item.CategoryEnter.CategoryId, Description = item.CategoryEnter.Description, Deleted = item.CategoryEnter.Deleted }
                        ////   User = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.UserModel() { UserId = item.Users.UserId, Email = item.Users.Email, Deleted = item.Users.Deleted, Role = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.RoleModel() { RoleId = item.Users.Role.RoleId, Name = item.Users.Role.Name, Deleted = item.Users.Role.Deleted }, Person = new Univalle.Fie.Sistemas.UniBook.AppUnibookRegisterMvc.Models.PersonModel() { PersonId = item.Users.Person.PersonId, Name = item.Users.Person.Name, LastName = item.Users.Person.LastName, BirthDay = item.Users.Person.BirthDay } }

                    });
                }
                return _commentListModel;
            }
        }
        // GET: Comment
        public ActionResult Index()
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Create"] = _localizer["Create"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            List<CommentModel> list = null;
            try
            {
                list = CommentListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {

                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(list);
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];


            WebCommentService.CommentEnterDto comment = null;
            

            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentService");

                //  Create instance of SOAP client
                WebCommentService.WebCommentServiceSoapClient soapClient = new WebCommentService.WebCommentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                comment = soapClient.Get(id);
                
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

            CommentModel commentModel = new CommentModel
            {
                CommentId= comment.CommentId,
                CommentText=comment.CommentText,
                DateHour = comment.DateHour,
                Deleted = comment.Deleted
             //   Entertainment=  new EntertainmentModel() { }
            };
           

            return View(commentModel);
        }

        // GET: Comment/Create
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

        // POST: Comment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CommentModel comment)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentService");

                WebCommentService.WebCommentServiceSoapClient soapClient = new WebCommentService.WebCommentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebCommentService.CommentEnterDto commentModel = new WebCommentService.CommentEnterDto
                {

                    CommentText= comment.CommentText,
                    DateHour = comment.DateHour,
                    Deleted = false,
                    Entertainment= new WebCommentService.EntertainmentDto() {EntertainmentId=1 },
                    User = new WebCommentService.UserDto() { UserId = 5 }


                };

                soapClient.Insert(commentModel);


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

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            WebCommentService.CommentEnterDto comment = null;
            try
            {





                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentService");

                //  Create instance of SOAP client
                WebCommentService.WebCommentServiceSoapClient soapClient = new WebCommentService.WebCommentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                comment = soapClient.Get(id);
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
            CommentModel commentModel = new CommentModel
            {
                CommentId = comment.CommentId,
                CommentText = comment.CommentText,
                DateHour = comment.DateHour,
                Deleted = comment.Deleted
                //   Entertainment=  new EntertainmentModel() { }
            };

            return View(commentModel);

        }

        // POST: Comment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CommentModel comment)
        {
            try
            {
                // TODO: Add update logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentService");
                WebCommentService.WebCommentServiceSoapClient soapClient = new WebCommentService.WebCommentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebCommentService.CommentEnterDto commentModel = new WebCommentService.CommentEnterDto
                {
                    CommentText = comment.CommentText,
                    DateHour = comment.DateHour,
                    Deleted = false,
                    Entertainment = new WebCommentService.EntertainmentDto() { EntertainmentId = 1 },
                    User = new WebCommentService.UserDto() { UserId = 5 }



                };
               soapClient.Update(commentModel);
                
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

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentService");
            CommentModel commentModel = null;
            try
            {
                // TODO: Add update logic here
                WebCommentService.WebCommentServiceSoapClient soapClient = new WebCommentService.WebCommentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebCommentService.CommentEnterDto comment = soapClient.Get(id);
                commentModel = new CommentModel()
                {
                    CommentId = comment.CommentId,
                    CommentText = comment.CommentText,
                    DateHour = comment.DateHour,
                    Deleted = comment.Deleted

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


            return View(commentModel);
        }

        // POST: Comment/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCommentService");
                WebCommentService.WebCommentServiceSoapClient soapClient = new WebCommentService.WebCommentServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
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