using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace Movies_Versions
{
    public class RandomApiVersionSelector : IApiVersionSelector
    {
        public ApiVersion SelectVersion(HttpRequest request, ApiVersionModel model)
        {

            Random random = new Random();
            int randomNumber = random.Next(0, model.SupportedApiVersions.Count());
            ApiVersion version = model.SupportedApiVersions[randomNumber];
             
            return version;
        }
    }
}
