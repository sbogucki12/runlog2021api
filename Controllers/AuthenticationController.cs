using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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

        // GET: api/Authentication
        [HttpGet]
        public IActionResult Get([FromHeader] String pw)
        {
            var secret = Configuration["Authentication:password"];
            var success = Configuration["Authentication:success"];
            var failure = Configuration["Authentication:failure"];
            if (pw == secret)
            {
                return Ok(success);
            }

            else if (pw != secret)
            {
                return BadRequest(failure);
            }

            return BadRequest("Error in request.");

        }
    }
}
