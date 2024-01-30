using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public int MyProperty { get; set; }

        private int myVar;

        public int fyfhr
        {
            get { return myVar; }
            set { myVar = value; }
        }

        IActionResult dedefde;
        XmlDsigC14NWithCommentsTransform dnewhbye;
        ValidationProblemDetailsWrapper validationProblemDetails;           


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}