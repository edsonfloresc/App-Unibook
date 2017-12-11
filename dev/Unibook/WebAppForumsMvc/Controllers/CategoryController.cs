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
    public class CategoryController : Controller
    {
        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private ILogger<CategoryController> logger;

        public CategoryController(ILogger<CategoryController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            this.logger = logger;
            _iconfiguration = iconfiguration;
        }
        public List<CategoryModel> CategoryListModel
        {
            get
            {
                WebCategoryListService.CategoryDto[] categorys = null;
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:CategoryList:WebCategoryListService");
                    //Create instance of SOAP client
                    WebCategoryListService.WebCategoryListServiceSoapClient soapClient = new WebCategoryListService.WebCategoryListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    categorys = soapClient.Get();
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

                List<CategoryModel> categoryModel = new List<CategoryModel>();
                foreach (var category in categorys)
                {
                    categoryModel.Add(new CategoryModel
                    {
                        CategoryId = category.CategoryId,
                        Name = category.Name,
                        Purpose = category.Purpose
                    });
                }
                return categoryModel;
            }
        }
        // GET: Category
        public ActionResult Index()
        {
            List<CategoryModel> model = null;
            try
            {
                model = CategoryListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }

            return View(model);
        }

        // GET: Category/Details/5
        public ActionResult Details(short id)
        {
            WebCategoryService.CategoryDto categoryDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Category:WebCategoryService");
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                categoryDto = soapClient.Get(id);
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

            CategoryModel categoryModel = new CategoryModel()
            {
                CategoryId = categoryDto.CategoryId,
                Name = categoryDto.Name,
                Purpose = categoryDto.Purpose
            };
            return View(categoryModel);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            try
            {

                CategoryController categoryController = new CategoryController(logger, _iconfiguration);
                ViewBag.ListCategory = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                            (
                                from category in categoryController.CategoryListModel
                                select new SelectListItem
                                {
                                    Text = category.Name,
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

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryModel categoryModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Category:WebCategoryService");

                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebCategoryService.CategoryDto category = new WebCategoryService.CategoryDto()
                {
                    Name = categoryModel.Name,
                    Purpose = categoryModel.Purpose
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

        // GET: Category/Edit/5
        public ActionResult Edit(short id)
        {
            CategoryController categoryController = new CategoryController(logger, _iconfiguration);
            WebCategoryService.CategoryDto categoryDto = null;
            try
            {
                ViewBag.ListCategory = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                      (
                          from category in categoryController.CategoryListModel
                          select new SelectListItem
                          {
                              Text = category.Name,
                              Value = category.CategoryId.ToString()
                          }
                      )
                      , "Value", "Text");

                var url = _iconfiguration.GetValue<string>("WebServices:Category:WebCategoryService");
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                categoryDto = soapClient.Get(id);
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

            CategoryModel categoryModel = new CategoryModel()
            {
                CategoryId = categoryDto.CategoryId,
                Purpose = categoryDto.Purpose,
                Name = categoryDto.Name
            };

            return View(categoryModel);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryModel categoryModel)
        {
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:Category:WebCategoryService");
                // TODO: Add update logic here
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                // TODO: Add insert logic here
                WebCategoryService.CategoryDto category = new WebCategoryService.CategoryDto()
                {
                    CategoryId = categoryModel.CategoryId,
                    Purpose = categoryModel.Purpose,
                    Name = categoryModel.Name,
                };
                soapClient.Update(category);

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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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