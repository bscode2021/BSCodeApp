using BSCodeAPI.Services.Interface;
using BSCodeModels_Lib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BSCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private ITrainerService _service;

        public TrainerController(ITrainerService service)
        {
            _service = service;
        }


        // GET: api/Trainer/GetAllTrainers
        [HttpGet("GetAllTrainers")]
        public List<Trainer> GetAllTrainers()
        {
            return _service.Get();
        }

        // GET api/Trainer/GetTrainerByID/07FFA69F-8959-4EE8-B6F1-5795F987E3F6
        [HttpGet("GetTrainerByID/{id}")]
        public Trainer GetTrainerByID(Guid id)
        {
            return _service.Get(id);
        }

        // POST api/Trainer/AddTrainer
        [HttpPost("AddTrainer")]
        public bool AddTrainer([FromBody] Trainer trainer)
        {
            return _service.Add(trainer);
        }

        // PUT api/Trainer/UpdateTraner
        [HttpPut("UpdateTrainer")]
        public Trainer UpdateTraner([FromBody] Trainer trainer)
        {
            return _service.Update(trainer);
        }

        // DELETE api/Trainer/Delete/07FFA69F-8959-4EE8-B6F1-5795F987E3F6
        [HttpDelete("Delete/{id}")]
        public bool Delete(Guid id)
        {
            return _service.Delete(id);
        }
    }
}
