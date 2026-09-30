using Microsoft.AspNetCore.Mvc;
using ReflectionConsoleApp.Dtos;

namespace ReflectionConsoleApp.Controllers
{
    [Route("api/[controller]/[action]")]
    public class WatchController : ControllerBase
    {
        [HttpGet]
        public IActionResult PlayVideo([FromQuery] int id, [FromQuery] string name)
        {
            return Ok(new { Message = $"Playing video with ID: {id} and Name: {name}" });
        }

        [HttpDelete]
        public IActionResult DeleteVideo([FromQuery] int id, [FromQuery] string name)
        {
            return Ok(new { Message = $"Deleted video with ID: {id} and Name: {name}" });
        }

        [HttpPost]
        public IActionResult AddVideo([FromBody] VideoDTO video)
        {
            return Ok(new { Message = $"Added video with name: {video.Name}" });
        }
    }
}