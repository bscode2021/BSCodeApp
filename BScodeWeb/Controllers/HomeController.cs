using BSCodeModels_Lib;
using BScodeWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace BScodeWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly HttpClient _client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<ActionResult> Projects()
        {
            HttpResponseMessage response = await _client.GetAsync("https://localhost:44381/api/Project/GetAllProject");
            List<Project> projects = await response.Content.ReadAsAsync<List<Project>>();

            return View(projects);
        }

        public IActionResult Trainers()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("ProjectDetails/{id?}")]
        public IActionResult ProjectDetails(int id)
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
