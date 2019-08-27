using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers
{


    [ApiVersionNeutral]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get() => HttpContext.GetRequestedApiVersion().ToString();

    }
}
