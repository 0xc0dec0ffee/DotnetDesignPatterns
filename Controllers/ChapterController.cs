using ExampleClassLibrary.Chapter2;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChapterController: ControllerBase
    {
        [HttpPost]
        public IActionResult Ch2([FromServices]TaxEngine taxEngine)
        {
            taxEngine.Demo();
            return Ok(taxEngine.GetOK());
        }
        [HttpPost]
        public IActionResult Ch3([FromServices]TaxEngine taxEngine)
        {
            taxEngine.Demo();
            return Ok(taxEngine.GetOK());
        }
    }
}
