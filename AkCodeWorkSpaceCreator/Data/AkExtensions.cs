using Newtonsoft.Json;
using System.Collections.Generic;

namespace AkCodeWorkSpaceCreator.Data
{
    [JsonObject]
    class AkExtensions
    {
        [JsonProperty("recommendations")]
        public List<string> Recommendations { get; set; }

        public AkExtensions()
        {
            Recommendations = new List<string>();
        }
    }
}