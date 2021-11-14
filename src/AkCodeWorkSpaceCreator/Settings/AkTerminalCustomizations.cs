using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkCodeWorkSpaceCreator.Settings
{
    internal class AkTerminalCustomizations
    {
        public AkTerminalCustomizations(Dictionary<string, object> settings)
        {
            var innerData = new Dictionary<string, object>();
            var innerData2 = new Dictionary<string, object>();
            settings["terminal.integrated.profiles.windows"] = innerData;

            innerData["PowerShell"] = innerData2;
            var innerList = new List<string>();
            innerData2["path"] = innerList;
            innerList.Add(@"C:\Program Files\PowerShell\7\pwsh.exe");

            innerData["icon"] = "terminal-powershell";

            //    "terminal.integrated.profiles.windows": {
            //        "PowerShell": {
            //            "path": [
            //              "C:\\Program Files\\PowerShell\\7\\pwsh.exe"
            //          ],
            //"icon": "terminal-powershell"
            //        },
        }
    }
}
