using Microsoft.AspNetCore.Mvc;

namespace Kestrel2.Controllers
{
    [Route("/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet("{name}")]
        public string Get() => "Hello World!";
    }
}