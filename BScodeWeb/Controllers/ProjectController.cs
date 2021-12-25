using BSCodeModels_Lib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BScodeWeb.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProjectController : Controller
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<IActionResult> Add()
        {
            HttpResponseMessage response = await _client.GetAsync("https://localhost:44381/api/Trainer/GetAllTrainers");

            List<Trainer> trainers = new List<Trainer>();

            if (response.IsSuccessStatusCode)
                trainers = await response.Content.ReadAsAsync<List<Trainer>>();

            ViewBag.Trainers = trainers;

            return View(new Project());
        }

        public IActionResult AddProject(Project project)
        {
            return RedirectToAction("Add");
        }

        public IActionResult UpdateProject(Project project)
        {
            return RedirectToAction("Add");
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
