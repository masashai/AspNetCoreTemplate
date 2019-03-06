using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTemplate.ViewModels;
using Microsoft.Extensions.Logging;
using AspNetCoreTemplate.Controllers.Base;
using AspNetCoreTemplate.Services;

namespace AspNetCoreTemplate.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger _logger;
        private readonly IHomeService _homeService;

        public HomeController(ILogger<HomeController> logger, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }
        public IActionResult Index()
        {
            _logger.LogWarning("Custom Log");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = _homeService.GetAboutMessage();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = _homeService.GetContactMessage();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogError("Error Occurred");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
