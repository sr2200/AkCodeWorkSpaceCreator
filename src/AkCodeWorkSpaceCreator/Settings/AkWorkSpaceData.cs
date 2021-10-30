using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkCodeWorkSpaceCreator.Settings
{
    /// <summary>
    /// ワークスペースのカスタム設定データクラス
    /// </summary>
    [JsonObject]
    class AkWorkSpaceData
    {
        [JsonProperty("folders")]
        public List<AkFolderData> Folders { get; set; }

        [JsonProperty("settings")]
        public Dictionary<string,object> Settings { get; set; }

        [JsonProperty("extensions")]
        public AkExtensions Extensions { get; set; }

        public AkWorkSpaceData()
        {
            Folders = new List<AkFolderData>();
            Settings = new Dictionary<string, object>();
            new AkCustomSettings(Settings);
            Extensions = new AkExtensions();
        }
    }
}
