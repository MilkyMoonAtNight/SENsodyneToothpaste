using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuleController : ControllerBase
    {
        private static List<Module> _modules = new()
        {
            new Module { Id = 1, ModuleName = "Intro to Programming", ModuleCode = "IT101" },
            new Module { Id = 2, ModuleName = "Data Structures", ModuleCode = "IT202" }
        };

        [HttpGet]
        public IActionResult GetModules() => Ok(_modules);

        [HttpGet("{id}")]
        public IActionResult GetModule(int id)
        {
            var module = _modules.FirstOrDefault(m => m.Id == id);
            return module == null ? NotFound() : Ok(module);
        }

        [HttpPost("{id}/topics")]
        public IActionResult AddTopic(int id, [FromBody] Topic topic)
        {
            var module = _modules.FirstOrDefault(m => m.Id == id);
            if (module == null) return NotFound(new { message = "Module not found" });

            topic.Id = module.Topics.Count + 1;
            module.Topics.Add(topic);
            return Ok(topic);
        }
    }
}
