using Microsoft.AspNetCore.Mvc;
using POCMVCWithDependencyInjection.Interfaces;
using POCMVCWithDependencyInjection.Models;
using System.Diagnostics;

namespace POCMVCWithDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        IMyService _service;

        public HomeController(IMyService service)
        {
            _service = service;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
