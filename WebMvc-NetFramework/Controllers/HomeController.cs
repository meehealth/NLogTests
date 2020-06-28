using CommonLib;
using NLog;
using System.Web.Mvc;

namespace WebMvc_NetFramework.Controllers
{
    public class HomeController : Controller
    {
        private static ILogger Logger = LogManager.GetCurrentClassLogger();
        private static ILogger LoggerAudit = LogManager.GetLogger("MeeHealth.Audit");
        private IDateService _dateService;

        public HomeController(IDateService dateService)
        {
            _dateService = dateService;
        }

        public ActionResult Index()
        {
            Logger.Info("HomeController.Index:" + _dateService.GetDateTime().ToString());
            LoggerAudit.Info("HomeController.Audit");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}