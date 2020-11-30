using Microsoft.AspNetCore.Mvc;
using runlog2021api.Models;
using runlog2021api.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (!ModelState.IsValid) 
            {
                return BadRequest("Run Format Is Invalid");
            }
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

        //This method is to help convert data from the old run log to data model of new run log  
        [HttpPost]
        [Route("/api/convert")]
        public List<Run> ConvertJsonToRun([FromBody] List<OldRun> oldRuns)
        {
            var runs = new List<Run>();

            for (var i = 0; i < oldRuns.Count; i++)
            {
                var run = new Run();

                run.Date = DateTime.Parse(oldRuns[i].Date);
                run.Duration = TimeSpan.FromSeconds(oldRuns[i].Duration * 60);
                run.Length = oldRuns[i].Distance;
                run.Surface = oldRuns[i].Comment.ToString();
                run.RunKey = oldRuns[i].Key;
                runs.Add(run);
            }

            _dataRepository.AddMany(runs);

            return _dataRepository.GetAll().ToList();
        }
    }
}
