using BSCodeModels_Lib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BScodeWeb.Controllers
{
    public class TrainerController : Controller
    {
        private static readonly Uri _baseUrl = new Uri("https://localhost:44381/api/Trainer/");
        private static readonly string _imgPath = Environment.CurrentDirectory + "\\wwwroot\\img\\Trainers\\";

        [HttpGet]
        public async Task<IActionResult> List()
        {
            if (TempData["IsSuccess"] != null)
            {
                ViewBag.IsSuccess = TempData["IsSuccess"].ToString();
            }
            List<Trainer> trainersList = new List<Trainer>();

            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;

                HttpResponseMessage response = await _client.GetAsync("GetAllTrainers");

                if (response.IsSuccessStatusCode)
                    trainersList = await response.Content.ReadAsAsync<List<Trainer>>();
            }

            return View(trainersList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            Trainer trainer = new Trainer();

            return View(trainer);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Trainer trainer = new Trainer();

            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;

                HttpResponseMessage response = await _client.GetAsync("GetTrainerByID/" + id);

                if (response.IsSuccessStatusCode)
                    trainer = await response.Content.ReadAsAsync<Trainer>();
            }

            return View(trainer);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Trainer trainer, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    using (var stream = new FileStream(_imgPath + ImageFile.FileName, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }

                    trainer.Image = ImageFile.FileName;
                }

                using (HttpClient _client = new HttpClient())
                {
                    _client.BaseAddress = _baseUrl;
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await _client.PostAsJsonAsync("AddTrainer", trainer);

                    if (response.IsSuccessStatusCode)
                    {
                        TempData["IsSuccess"] = "Successfuly Added Trainer!";
                        return RedirectToAction("List");
                    }
                    else
                    {
                        return View(trainer);
                    }
                }
            }
            else
            {
                return View(trainer);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Trainer trainer, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    using (var stream = new FileStream(_imgPath + ImageFile.FileName, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }

                    trainer.Image = ImageFile.FileName;
                }

                using (HttpClient _client = new HttpClient())
                {
                    _client.BaseAddress = _baseUrl;
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await _client.PutAsJsonAsync("UpdateTrainer", trainer);

                    if (response.IsSuccessStatusCode)
                    {
                        TempData["IsSuccess"] = "Successfuly Edited Trainer!";
                        return RedirectToAction("List");
                    }
                    else
                    {
                        return View(trainer);
                    }
                }
            }
            else
            {
                return View(trainer);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            Trainer trainer = new Trainer();

            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;

                HttpResponseMessage response = await _client.DeleteAsync("Delete/" + id);

                if (response.IsSuccessStatusCode)
                    return RedirectToAction("List");
                else
                    return RedirectToAction("List");
            }
        }
    }
}
