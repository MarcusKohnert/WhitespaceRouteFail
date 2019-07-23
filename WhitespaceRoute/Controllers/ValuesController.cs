using Microsoft.AspNetCore.Mvc;

namespace WhitespaceRoute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("whitespace ")]
        public ActionResult<string> Whitespace() => "Hi";

        [HttpGet("nowhitespace")]
        public ActionResult<string> NoWhitespace() => "Hi";
    }
}