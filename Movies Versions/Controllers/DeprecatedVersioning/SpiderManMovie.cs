using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers.DeprecatedVersioning
{
    [Route("api/deprecating/[controller]")]
    [ApiController]
    public class SpiderManMovie
    {
        // GET /api/deprecating/spidermanmovie
        [HttpGet, ApiVersion("1.0", Deprecated = true)]
        public string GetV1() => "SpiderMan (Tobey Maguire)";

        [HttpGet, ApiVersion("2.0", Deprecated = true)]
        public string GetV2() => "SpiderMan 2 (Tobey Maguire)";

        [HttpGet, ApiVersion("3.0", Deprecated = true)]
        public string GetV3() => "SpiderMan 3 (Tobey Maguire)";

        [HttpGet, ApiVersion("4.0", Deprecated = true)]
        public string GetV4() => "The Amazing Spider-Man (Andrew Garfield)";

        [HttpGet, ApiVersion("5.0")]
        public string GetV5() => "Spider-Man: Homecoming (Tom Holland)";

        [HttpGet, ApiVersion("6.0")]
        public string GetV6() => "Spider-Man: Far From Home​ (Tom Holland)";

    }
}
