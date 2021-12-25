using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BScodeWeb.Controllers
{
    [Authorize(Roles = "admin")]
    public class ContactWebContentController : Controller
    {
        public IActionResult Add()
        {
            return View();
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
