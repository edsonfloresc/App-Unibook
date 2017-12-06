using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models;
using System.ServiceModel;

namespace UnibookEntertainmentMvc.Controllers
{
    public class CategoryListController : Controller
    {


        private readonly ILogger _logger;
        IConfiguration _iconfiguration;

        public CategoryListController(ILogger logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
           
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


        // GET: CategoryList
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryList/Create
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

        // GET: CategoryList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryList/Edit/5
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

        // GET: CategoryList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryList/Delete/5
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