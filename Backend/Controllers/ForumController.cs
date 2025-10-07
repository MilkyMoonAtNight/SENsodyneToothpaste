using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForumController : ControllerBase
    {
        private static List<Topic> _topics = new();

        [HttpGet("{moduleId}/topics")]
        public IActionResult GetTopics(int moduleId)
        {
            return Ok(_topics.Where(t => t.Id == moduleId));
        }

        [HttpPost("{moduleId}/topics")]
        public IActionResult CreateTopic(int moduleId, [FromBody] Topic topic)
        {
            topic.Id = _topics.Count + 1;
            _topics.Add(topic);
            return Created("", topic);
        }
    }
}
