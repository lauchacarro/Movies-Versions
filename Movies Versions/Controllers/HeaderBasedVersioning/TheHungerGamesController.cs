using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers.HeaderBasedVersioning
{

    [Route("api/header/[controller]")]
    [ApiController]
    public class TheHungerGamesController : ControllerBase
    {
        // GET /api/header/TheHungerGames

        [HttpGet, ApiVersion("1.0")]
        public string GetV1() => "The Hunger Games";

        [HttpGet, ApiVersion("2.0")]
        public string GetV2() => "The Hunger Games: Catching Fire";

        [HttpGet, ApiVersion("3.1")]
        public string GetV31() => "The Hunger Games: Mockingjay Part 1";

        [HttpGet, ApiVersion("3.2")]
        public string GetV32() => "The Hunger Games: Mockingjay Part 2";
    }
}