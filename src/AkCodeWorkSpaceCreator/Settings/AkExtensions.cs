using Newtonsoft.Json;
using System.Collections.Generic;

namespace AkCodeWorkSpaceCreator.Settings
{
    [JsonObject]
    class AkExtensions
    {
        [JsonProperty("recommendations")]
        public List<string> Recommendations { get; set; }

        public AkExtensions()
        {
            Recommendations = new List<string>();

            Recommendations.Add("ms-ceintl.vscode-language-pack-ja");
            Recommendations.Add("vscode-icons");
            Recommendations.Add("esbenp.prettier-vscode");
        }
    }
}