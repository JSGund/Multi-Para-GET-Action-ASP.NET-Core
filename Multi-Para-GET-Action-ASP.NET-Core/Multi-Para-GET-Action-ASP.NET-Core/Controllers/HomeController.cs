using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Multi_Para_GET_Action_ASP.NET_Core.Models;
using System.Diagnostics;

namespace Multi_Para_GET_Action_ASP.NET_Core.Controllers
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

        [HttpGet("{id}/{backendOnly}")]
        public IActionResult Get(int id, string backendOnly)
        {
            return Content("id - " + id + " and backendOnly - " + backendOnly);
        }

        [Route("details")]
        [HttpGet]
        public IActionResult Details(int id, string backendOnly)
        {
            return Content("id - " + id + " and backendOnly - " + backendOnly);
        }

        [Route("id")]
        [HttpGet]
        public IActionResult BothDetails(int id, string backendOnly, string frontendOnly)
        {
            var str = "Using both ways : id - " + id + " and backendOnly - " + backendOnly + " and frontendOnly -" + frontendOnly;
            return Content(str);
        }

        [Route("getaction")]
        [HttpGet]
        public IActionResult GetAction(GetRequest getRequest)
        {
            return Content("Using both ways : id - " + getRequest.Id + " and backendOnly - " + getRequest.BackEnd);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
