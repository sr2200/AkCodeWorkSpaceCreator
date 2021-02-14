using Newtonsoft.Json;

namespace AkCodeWorkSpaceCreator.Data
{
    [JsonObject]
    class AkCustomSettings
    {
        [JsonProperty("workbench.colorCustomizations")]
        public AkColorCustomizations ColorCustomizations { get; set; }

        public AkCustomSettings()
        {
            ColorCustomizations = new AkColorCustomizations();
        }
    }

}
