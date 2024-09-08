using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly List<string> sampleData = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3"
        };

        // GET: api/sample
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(sampleData);
        }

        // GET: api/sample/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id >= 0 && id < sampleData.Count)
            {
                return Ok(sampleData[id]);
            }

            return NotFound("Item not found");
        }
    }
}
