using BSCodeAPI.Services.Interface;
using BSCodeModels_Lib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BSCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            this._projectService = projectService ?? throw new ArgumentNullException(nameof(projectService));
        }

        // GET: api/<ValuesController>
        [HttpGet("GetAllProject")]
        public List<Project> GetAllProject()
        {
            return _projectService.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("GetProject/{id}")]
        public Project GetProjectByID(Guid id)
        {
            return _projectService.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPut("UpdateProject")]
        public Project UpdateProject([FromBody] Project project)
        {
            return _projectService.Update(project);
        }

        // POST api/<ValuesController>
        [HttpPost("AddProject")]
        public bool AddProject([FromBody] Project project)
        {
            return _projectService.Add(project);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteProject/{id}")]
        public bool DeleteProjectByID(Guid id)
        {
            return _projectService.Delete(id);
        }
    }
}
