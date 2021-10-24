using Newtonsoft.Json;

namespace AkCodeWorkSpaceCreator.Data
{
    [JsonObject]
    class AkFolderData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

}
