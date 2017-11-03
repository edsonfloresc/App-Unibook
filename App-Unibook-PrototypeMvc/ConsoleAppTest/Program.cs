using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPersonListService.WebPersonListServiceSoapClient soapClient = new WebPersonListService.WebPersonListServiceSoapClient();
            soapClient.Get();

            WebPersonTypeListService.WebPersonTypeListServiceSoapClient sc = new WebPersonTypeListService.WebPersonTypeListServiceSoapClient();
            sc.Get();

            WebPersonService.WebPersonServiceSoapClient sc1 = new WebPersonService.WebPersonServiceSoapClient();
            sc1.Delete(new Guid());
          //  sc1.Get(new WebPersonService.PersonDto());
        }
    }
}
