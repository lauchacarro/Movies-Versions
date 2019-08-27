using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers.URLPathBasedVersioning
{
    [Route("api/path/[controller]")]
    [ApiController]
    public class TransformersMovieController : ControllerBase
    {
        // GET /api/path/TransformersMovie/1.0

        [HttpGet("{version:apiVersion}"), ApiVersion("1.0")]
        public string GetV1() => "Transformers";



        // GET /api/path/TransformersMovie/2.0

        [HttpGet("{version:apiVersion}"), ApiVersion("2.0")]
        public string GetV2() => "Transformers: Revenge of the Fallen";

        // GET /api/path/TransformersMovie/3.0

        [HttpGet("{version:apiVersion}"), ApiVersion("3.0")]
        public string GetV3() => "Transformers: Dark of the Moon";


        // GET /api/path/TransformersMovie/4.0

        [HttpGet("{version:apiVersion}"), ApiVersion("4.0")]
        public string GetV4() => "Transformers: Age of Extinction";

    }
}