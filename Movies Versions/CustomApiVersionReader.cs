using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace Movies_Versions
{
    public class CustomApiVersionReader : IApiVersionReader
    {
        const string HEADERNAME = "api-version-custom-header";
        public void AddParameters(IApiVersionParameterDescriptionContext context)
        {
            context.AddParameter(HEADERNAME, ApiVersionParameterLocation.Header);
        }

        public string Read(HttpRequest request)
        {
            if (request.Headers.ContainsKey(HEADERNAME))
            {
                string[] letters = request.Headers[HEADERNAME].ToString().Split('.');
                string version = string.Empty;
                foreach (string letter in letters)
                {
                    switch (letter)
                    {
                        case "one":
                            version += "1";
                            break;
                        case "two":
                            version += "2";
                            break;
                        case "three":
                            version += "3";
                            break;
                        case "four":
                            version += "4";
                            break;
                        case "five":
                            version += "5";
                            break;
                        case "six":
                            version += "6";
                            break;
                        case "seven":
                            version += "7";
                            break;
                        case "eight":
                            version += "8";
                            break;
                        case "nine":
                            version += "9";
                            break;
                        case "zero":
                            version += "0";
                            break;
                    }
                    if (letters.Last() != letter)
                    {
                        version += ".";
                    }
                }
                return version;
            }
            else
                return null;
        }
    }
}
