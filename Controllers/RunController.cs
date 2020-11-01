using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using runlog2021api.Models;
using runlog2021api.Models.Repository;

namespace runlog2021api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunController : ControllerBase
    {
        private readonly IDataRepository<Run> _dataRepository;
        public RunController(IDataRepository<Run> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // GET: api/Run
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Run> runs = _dataRepository.GetAll();
            return Ok(runs);
        }

        // GET: api/Run/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Run run = _dataRepository.Get(id);
            if (run == null)
            {
                return NotFound("The Run couldn't be found.");
            }
            return Ok(run);
        }

        // POST: api/Run
        [HttpPost]
        public IActionResult Post([FromBody] Run run)
        {
            if (run == null)
            {
                return BadRequest("Run is null.");
            }           

            _dataRepository.Add(run);
            return CreatedAtRoute(
                  "Get",
                  new { Id = run.RunId },
                  run);
        }

        // PUT: api/Run/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Run run)
        {
            if (run == null)
            {
                return BadRequest("Run is null.");
            }
            Run runToUpdate = _dataRepository.Get(id);
            if (runToUpdate == null)
            {
                return NotFound("The Run couldn't be found.");
            }
            _dataRepository.Update(runToUpdate, run);
            return NoContent();
        }

        // DELETE: api/Run/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Run run = _dataRepository.Get(id);
            if (run == null)
            {
                return NotFound("The Run couldn't be found.");
            }
            _dataRepository.Delete(run);
            return NoContent();
        }
    }
}
