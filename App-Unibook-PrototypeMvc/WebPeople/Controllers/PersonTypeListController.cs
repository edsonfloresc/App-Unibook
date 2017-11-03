using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Univalle.Fie.Sistemas.Unibook.Mvc.WebPeople.Models;
using System.ServiceModel;

namespace WebPeople.Controllers
{
    public class PersonTypeListController : Controller
    {
        private static List<PersonTypeModel> _personTypeListModel;

        public static List<PersonTypeModel> PersonTypeListModel
        {
            get
            {
                //Create instance of SOAP client
                WebPersonTypeListService.WebPersonTypeListServiceSoapClient soapClient = new WebPersonTypeListService.WebPersonTypeListServiceSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress("http://localhost:41142/WebPersonTypeListService.asmx"));
                WebPersonTypeListService.PersonTypeDto[] personTypeList = soapClient.Get();
                _personTypeListModel = new List<PersonTypeModel>();
                foreach (var item in personTypeList)
                {
                    _personTypeListModel.Add(new PersonTypeModel
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }
                return _personTypeListModel;
            }
            set { _personTypeListModel = value; }
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}