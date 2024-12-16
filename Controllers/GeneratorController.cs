using Microsoft.AspNetCore.Mvc;

namespace ArtificialBeauty.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GeneratorController : Controller
    {
        public IActionResult Test()
        {
            return Ok();
        }
    }
}

