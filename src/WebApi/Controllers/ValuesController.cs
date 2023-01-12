using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ApiControllerBase
    {
        private readonly IDateTime _datetime;
        public ValuesController(IDateTime dateTime)
        {
            _datetime= dateTime;
        }

        [HttpGet(Name = "api/[controller]/getnow")]
        public IActionResult Get()
        {
            return Ok(_datetime.Now.ToString());
        }
    }
}
