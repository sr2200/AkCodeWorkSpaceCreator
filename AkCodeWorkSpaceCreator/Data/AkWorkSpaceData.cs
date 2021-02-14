using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkCodeWorkSpaceCreator.Data
{
    [JsonObject]
    class AkWorkSpaceData
    {
        [JsonProperty("folders")]
        public List<AkFolderData> Folders { get; set; }

        [JsonProperty("settings")]
        public AkCustomSettings Settings { get; set; }

        [JsonProperty("extensions")]
        public AkExtensions Extensions { get; set; }

        public AkWorkSpaceData()
        {
            Folders = new List<AkFolderData>();
            Settings = new AkCustomSettings();
            Extensions = new AkExtensions();
        }
    }
}
