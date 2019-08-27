using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers.URLQueryBasedVersioning
{
    [Route("api/query/[controller]")]
    [ApiController]
    public class MatrixMovieController : ControllerBase
    {
        // GET api/query/matrixmovie?api-version-query=1.0

        [HttpGet, ApiVersion("1.0")]
        public string GetV1() => "The Matrix";

        // GET api/query/matrixmovie?api-version-query=2.0

        [HttpGet, ApiVersion("2.0")]
        public string GetV2() => "The Matrix Reloaded";

        // GET api/query/matrixmovie?api-version-query=3.0

        [HttpGet, ApiVersion("3.0")]
        public string GetV3() => "The Matrix Revolutions";
    }
}