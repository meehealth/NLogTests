using CommonLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebMvc_NetCore.Models;

namespace WebMvc_NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ILogger _loggerAudit;
        private IDateService _dateService;

        public HomeController(ILogger<HomeController> logger,
            ILoggerFactory loggerFactory,
            IDateService dateService)
        {
            _logger = logger;
            _loggerAudit = loggerFactory.CreateLogger("MeeHealth.Audit.Ecis.HomeController");
            _dateService = dateService;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("HomeController.Index:" + _dateService.GetDateTime().ToShortDateString());
            _loggerAudit.LogInformation("Audit information from HomeController");
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