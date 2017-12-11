using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using WebAppForumsMvc.Models;
using System.ServiceModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppForumsMvc.Controllers
{
    public class QuestionController : Controller
    {

        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private ILogger<QuestionController> logger;

        public QuestionController(ILogger<QuestionController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
        }
        public List<QuestionsModel> QuestionsListModel
        {
            get
            {
                WebQuestionsListService.QuestionsDto[] questions = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:QuestionsList:WebQuestionsListService");
                    //Create instance of SOAP client
                    WebQuestionsListService.WebQuestionsListServiceSoapClient soapClient = new WebQuestionsListService.WebQuestionsListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    questions = soapClient.Get();
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

                List<QuestionsModel> questionModel = new List<QuestionsModel>();
                foreach (var question in questions)
                {
                    questionModel.Add(new QuestionsModel
                    {
                        QuestionsId = question.QuestionsId,
                        Title = question.Title,
                        Content = question.Content,
                        Points = question.Points,
                        Solved = question.Solved,
                        Deleted = question.Deleted
                    });
                }
                return questionModel;
            }
        }
        // GET: Questios
        public ActionResult Index()
        {
            List<QuestionsModel> model = null;
            try
            {
                model = QuestionsListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Questios/Details/5
        public ActionResult Details(long id)
        {
            WebQuestionsService.QuestionsDto questionDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Questions:WebQuestionsService");
                WebQuestionsService.WebQuestionsServiceSoapClient soapClient = new WebQuestionsService.WebQuestionsServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                questionDto = soapClient.Get(id);
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

            QuestionsModel questionModel = new QuestionsModel()
            {
                QuestionsId = questionDto.QuestionsId,
                Title = questionDto.Title,
                Content = questionDto.Content,
                Points = questionDto.Points,
                Solved = questionDto.Solved,
                Deleted = questionDto.Deleted
            };
            return View(questionModel);
        }

        // GET: Questios/Create
        public ActionResult Create()
        {
            try
            {

                QuestionController questionController = new QuestionController(logger, _iconfiguration);
                ViewBag.ListQuestions = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from question in questionController.QuestionsListModel
                                select new SelectListItem
                                {
                                    Text = question.Title,
                                    Value = question.QuestionsId.ToString()
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

        // POST: Questios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionsModel questionsModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Questions:WebQuestionsService");

                WebQuestionsService.WebQuestionsServiceSoapClient soapClient = new WebQuestionsService.WebQuestionsServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebQuestionsService.QuestionsDto category = new WebQuestionsService.QuestionsDto()
                {
                    Title = questionsModel.Title,
                    Content = questionsModel.Content,
                    Points = questionsModel.Points,
                    Solved = questionsModel.Solved,
                    Deleted = questionsModel.Deleted
                };
                soapClient.Insert(category);
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

        // GET: Questios/Edit/5
        public ActionResult Edit(long id)
        {
            QuestionController questionsController = new QuestionController(logger, _iconfiguration);
            WebQuestionsService.QuestionsDto questionsDto = null;
            try
            {
                ViewBag.ListQuestions = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from questions in questionsController.QuestionsListModel
                          select new SelectListItem
                          {
                              Text = questions.Title,
                              Value = questions.QuestionsId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:Questions:WebQuestionsService");
                WebQuestionsService.WebQuestionsServiceSoapClient soapClient = new WebQuestionsService.WebQuestionsServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                questionsDto = soapClient.Get(id);
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

            QuestionsModel questionsModel = new QuestionsModel()
            {
                Title = questionsDto.Title,
                Content = questionsDto.Content,
                Points = questionsDto.Points,
                Solved = questionsDto.Solved,
                Deleted = questionsDto.Deleted
            };

            return View(questionsModel);
        }

        // POST: Questios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, QuestionsModel questionsModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Questions:WebQuestionsService");
                // TODO: Add update logic here
                WebQuestionsService.WebQuestionsServiceSoapClient soapClient = new WebQuestionsService.WebQuestionsServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebQuestionsService.QuestionsDto questions = new WebQuestionsService.QuestionsDto()
                {
                    Title = questionsModel.Title,
                    Content = questionsModel.Content,
                    Points = questionsModel.Points,
                    Solved = questionsModel.Solved,
                    Deleted = questionsModel.Deleted
                };
                soapClient.Update(questions);

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

        // GET: Questios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Questios/Delete/5
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