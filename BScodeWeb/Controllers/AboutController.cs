﻿using BSCodeModels_Lib;
using BScodeWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BScodeWeb.Controllers
{
    public class AboutController : Controller
    {
        private static readonly Uri _baseUrl = new Uri("https://localhost:44381/api/About/");
        private static readonly string _imgPath = Environment.CurrentDirectory + "\\wwwroot\\img\\About";

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(About about, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    using (var stream = new FileStream(_imgPath + "\\" + ImageFile.FileName, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }
                    about.ImageName = ImageFile.FileName;
                }
               

                using (HttpClient _client = new HttpClient())
                {
                    _client.BaseAddress = _baseUrl;
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _client.DefaultRequestHeaders.Accept.Clear();

                    HttpResponseMessage response = await _client.PostAsJsonAsync("AddAbout", about);

                    if (response.IsSuccessStatusCode)
                    {
                        ViewBag.Message = "Succeesfuly added about to the database";
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ViewBag.Message = response.StatusCode.ToString() + " - " + response.ReasonPhrase.ToString();
                        return View(about);
                    }
                }
            }
            else
            {
                return View(about);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            About about = new About();

            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await _client.GetAsync("GetAbout");

                if (response.IsSuccessStatusCode)
                    about = await response.Content.ReadAsAsync<About>();
            }

            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About about, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    using (var stream = new FileStream(_imgPath + "\\" + ImageFile.FileName, FileMode.Create))
                    {
                        await ImageFile.CopyToAsync(stream);
                    }
                    about.ImageName = ImageFile.FileName;
                }

                using (HttpClient _client = new HttpClient())
                {
                    _client.BaseAddress = _baseUrl;
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _client.DefaultRequestHeaders.Accept.Clear();

                    HttpResponseMessage response = await _client.PutAsJsonAsync("UpdateAbout", about);

                    if (response.IsSuccessStatusCode)
                    {
                        ViewBag.Message = "Succeesfuly added about to the database";
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ViewBag.Message = response.StatusCode.ToString() + " - " + response.ReasonPhrase.ToString();
                        return View(about);
                    }
                }
            }
            else
            {
                return View(about);
            }
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            About about = new About();

            using (HttpClient _client = new HttpClient())
            {
                _client.BaseAddress = _baseUrl;
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await _client.GetAsync("GetAbout");

                if (response.IsSuccessStatusCode)
                    about = await response.Content.ReadAsAsync<About>();
            }

            return View(about);
        }
    }
}