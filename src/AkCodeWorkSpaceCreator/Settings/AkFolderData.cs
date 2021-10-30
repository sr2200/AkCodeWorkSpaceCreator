using Newtonsoft.Json;

namespace AkCodeWorkSpaceCreator.Settings
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
