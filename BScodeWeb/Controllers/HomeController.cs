using BSCodeModels_Lib;
using BScodeWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BScodeWeb.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Uri _baseUrl = new Uri("https://localhost:44381/api/");

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            About about = new About();
            ViewBag.Points = new List<String>();
            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;
                HttpResponseMessage response = await _client.GetAsync("About/GetAbout");

                if (response.IsSuccessStatusCode)
                {
                    about = await response.Content.ReadAsAsync<About>();

                    if (about != null)
                        ViewBag.Points = about.AboutPoints.Split(';').ToList();
                    else
                        about = new About();
                }
            }

            return View(about);
        }

        public async Task<IActionResult> Projects()
        {
            List<Project> projects = new List<Project>();

            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;
                HttpResponseMessage response = await _client.GetAsync("Project/GetAllProject");

                if (response.IsSuccessStatusCode)
                    projects = await response.Content.ReadAsAsync<List<Project>>();
            }

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

        public IActionResult WebContent()
        {
            return View();
        }
    }
}
