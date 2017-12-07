using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Models;

namespace Univalle.Fie.Sistemas.UniBook.UnibookEntertainmentMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
