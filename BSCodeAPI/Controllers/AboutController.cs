using BSCodeAPI.Services.Interface;
using BSCodeModels_Lib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty Abouts, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BSCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private IAboutService _AboutService;

        public AboutController(IAboutService AboutService)
        {
            this._AboutService = AboutService ?? throw new ArgumentNullException(nameof(AboutService));
        }

        // GET: api/About
        [HttpGet("GetAbout")]
        public About GetAbout()
        {
            return _AboutService.Get();
        }


        // POST api/About
        [HttpPut("UpdateAbout")]
        public About UpdateAbout([FromBody] About About)
        {
            return _AboutService.Update(About);
        }

        // POST api/About
        [HttpPost("AddAbout")]
        public bool AddAbout([FromBody] About About)
        {
            return _AboutService.Add(About);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteAbout/{id}")]
        public bool DeleteAboutByID(Guid id)
        {
            return _AboutService.Delete(id);
        }
    }
}
