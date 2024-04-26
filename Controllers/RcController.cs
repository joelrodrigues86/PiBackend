using Microsoft.AspNetCore.Mvc;

namespace PiBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RcController : ControllerBase
    {
        [HttpPost]
        public IActionResult Control(object payload)
        {
            return Ok(payload);
        }
    }
}
