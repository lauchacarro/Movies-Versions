using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movies_Versions.Controllers.DefaultRandomVersioning
{
    [Route("api/default/[controller]")]
    [ApiController]
    public class StarWarsMovieController : ControllerBase
    {

        // GET /api/default/starwarsmovie

        [HttpGet, ApiVersion("1.0")]
        public string GetV1() => "StarWars: Episode I – The Phantom Menace";

        [HttpGet, ApiVersion("2.0")]
        public string GetV2() => "StarWars: Episode II – Attack of the Clones";

        [HttpGet, ApiVersion("3.0")]
        public string GetV3() => "StarWars: Episode III – Revenge of the Sith";

        [HttpGet, ApiVersion("4.0")]
        public string GetV4() => "StarWars: Episode IV – A New Hope";

        [HttpGet, ApiVersion("5.0")]
        public string GetV5() => "StarWars: Episode V – The Empire Strikes Back";

        [HttpGet, ApiVersion("6.0")]
        public string GetV6() => "StarWars: Episode VI – Return of the Jedi";

        [HttpGet, ApiVersion("7.0")]
        public string GetV7() => "StarWars: Episode VII – The Force Awakens";

        [HttpGet, ApiVersion("8.0")]
        public string GetV8() => "StarWars: Episode VIII – The Last Jedi";

        [HttpGet, ApiVersion("9.0")]
        public string GetV9() => "StarWars: Episode IX – The Rise of Skywalker";
    }
}