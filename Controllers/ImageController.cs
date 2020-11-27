using Microsoft.AspNetCore.Mvc;
using runlog2021api.Models;
using runlog2021api.Models.Repository;
using System.Collections.Generic;

namespace runlog2021api.Controllers
{

    public class Json
    {
        public string ImageTitle { get; set; }
        public List<byte> ImageData { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IDataRepository<Image> _dataRepository;

        public ImageController(IDataRepository<Image> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Json json)
        {
            if (json == null)
            {
                return BadRequest("Run is null.");
            }

            var img = new Image();
            byte[] imageData = new byte[json.ImageData.Count];

            for (var i = 0; i < json.ImageData.Count; i++)
            {
                imageData[i] = json.ImageData[i];
            }

            img.ImageData = imageData;
            img.ImageTitle = json.ImageTitle;
            _dataRepository.Add(img);

            return Ok();
            /*            return CreatedAtRoute(
                              "Get",
                              new { Id = img.Id },
                              img);*/
        }
    }
}
