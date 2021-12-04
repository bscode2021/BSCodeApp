using BSCodeModels_Lib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BScodeWeb.Controllers
{
    public class AboutWebContentController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(About about)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("List");
            }
            else
            {
                return View(about);
            }
           
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
