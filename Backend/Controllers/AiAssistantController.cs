using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AiAssistantController : ControllerBase
    {
        [HttpPost("query")]
        public IActionResult Query([FromBody] AiQueryRequest request)
        {
            var response = new
            {
                responseId = Guid.NewGuid().ToString(),
                reply = $"AI Response to '{request.Message}'",
                timestamp = DateTime.UtcNow
            };

            return Ok(response);
        }

        [HttpGet("history")]
        public IActionResult GetHistory()
        {
            return Ok(new { message = "Chat history feature not implemented yet." });
        }
    }
}
