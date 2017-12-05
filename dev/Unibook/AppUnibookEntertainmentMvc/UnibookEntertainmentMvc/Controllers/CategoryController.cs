using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Controllers
{
    public class CategoryController : Controller
    {


        private readonly ILogger _logger;
        IConfiguration _iconfiguration;
        private readonly IStringLocalizer<CategoryController> _localizer;

        public CategoryController(ILogger<CategoryController> logger, IConfiguration iconfiguration, IStringLocalizer<CategoryController> localizer)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
            _localizer = localizer;
        }


        public List<CategoryModel> CategoryListModel
        {
            get
            {
                WebCategoryListService.CategoryEnterDto[] categoryList = null;
                
                try
                {
                    var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryListService");

                    //  Create instance of SOAP client
                    WebCategoryListService.WebCategoryListServiceSoapClient soapClient = new WebCategoryListService.WebCategoryListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                    categoryList = soapClient.Get();
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
                List<CategoryModel> _categoryListModel = new List<CategoryModel>();
                foreach (var item in categoryList)
                {
                    _categoryListModel.Add(new CategoryModel
                    {
                        CategoryId = item.CategoryId,
                        Description = item.Description,
                        Deleted = item.Deleted


                    });
                }
                return _categoryListModel;
            }
        }
        // GET: Category
        public ActionResult Index()
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Create"] = _localizer["Create"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            List<CategoryModel> list = null;
            try
            {
                list = CategoryListModel;
            }
            catch (System.Net.Http.HttpRequestException ex)
            {

                _logger.LogCritical(ex.Message);
                _logger.LogCritical(ex.StackTrace);
            }
            
            return View(list);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];



            WebCategoryService.CategoryEnterDto category = null;

            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryService");

                //  Create instance of SOAP client
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                category = soapClient.GetDto(id);
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
            CategoryModel categoryModel2 = new CategoryModel() 
                {
                    CategoryId = category.CategoryId,
                    Description = category.Description,
                    Deleted = category.Deleted


                };
            
            return View(categoryModel2);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            try
            {

               // PersonTypeListController personTypeController = new PersonTypeListController(_logger, _iconfiguration);
                //ViewBag.ListCategoryType = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                //            (
                //                from personType in personTypeController.PersonTypeListModel
                //                select new SelectListItem
                //                {
                //                    Text = personType.Name,
                //                    Value = personType.Id.ToString()
                //                }
                //            )
                //            , "Value", "Text");
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
                // TODO: Add insert logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryService");
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebCategoryService.CategoryEnterDto category = new WebCategoryService.CategoryEnterDto()
                {

                    Description = categoryModel.Description,
                    Deleted = false
                };
                soapClient.InsertAsync(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            WebCategoryService.CategoryEnterDto categoryDto = null;
            try
            {
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryService");

                //  Create instance of SOAP client
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                categoryDto = soapClient.GetDto(id);
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
            CategoryModel categoryModel2 = new CategoryModel()
            {
                CategoryId = categoryDto.CategoryId,
                Description = categoryDto.Description,
                Deleted = categoryDto.Deleted

            };

            return View(categoryModel2);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryModel categoryDto)
        {
            try
            {
                // TODO: Add update logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryService");
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebCategoryService.CategoryEnterDto category = new WebCategoryService.CategoryEnterDto()
                {
                    CategoryId = categoryDto.CategoryId,
                     Description = categoryDto.Description,
                      Deleted = categoryDto.Deleted
                };
                soapClient.Update(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            ViewData["Index"] = _localizer["Index"];
            ViewData["Edit"] = _localizer["Edit"];
            ViewData["Details"] = _localizer["Details"];
            ViewData["Delete"] = _localizer["Delete"];

            var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryService");
            CategoryModel categoryModel = null;
            try
            {
                // TODO: Add update logic here
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
                WebCategoryService.CategoryEnterDto category = soapClient.GetDto(id);
                categoryModel= new CategoryModel()
                {
                    CategoryId = category.CategoryId,
                    Description = category.Description,
                    Deleted = category.Deleted
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
           

            return View(categoryModel);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var url = _iconfiguration.GetValue<string>("WebServices:CaregoryEnter:WebCategoryService");
                WebCategoryService.WebCategoryServiceSoapClient soapClient = new WebCategoryService.WebCategoryServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(url));
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