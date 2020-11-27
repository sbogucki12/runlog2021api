using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using runlog2021api.Models;

namespace runlog2021api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration Configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // POST: api/Authentication
        [HttpPost]
        public IActionResult Post([FromBody] Authentication auth)
        {
            var pw = auth.Password;

            var secret = Configuration["Authentication:password"];
            var success = Configuration["Authentication:success"];
            //var failure = Configuration["Authentication:failure"];
            if (pw == secret)
            {
                return Ok(success);
            }

            else if (pw != secret)
            {
                return NoContent();
            }

            return BadRequest("Error in request.");
        }
    }
}
