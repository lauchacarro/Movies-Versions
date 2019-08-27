using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers.MapBasedVersioning
{
    [Route("api/map/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    public class FindingNemoController : ControllerBase
    {
        // GET /api/map/findingnemo
        [HttpGet]
        public string GetV1() => "Finding Nemo";

        [HttpGet, MapToApiVersion("2.0")]
        public string GetV2() => "Finding Dory";
    }
}