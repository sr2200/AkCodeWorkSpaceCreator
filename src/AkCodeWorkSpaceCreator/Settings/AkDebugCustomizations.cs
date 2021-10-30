using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkCodeWorkSpaceCreator.Settings
{
    public class AkDebugCustomizations
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="settings"></param>
        public AkDebugCustomizations(Dictionary<string, object> settings)
        {
            // デバッグ中にエディタの行内に変数値を表示する
            settings["debug.inlineValues"] = true;
            // いつ内部デバッグコンソールを開くかを制御する
            settings["debug.internalConsoleOptions"] = "openOnSessionStart";
            // いつデバッグビューを開くかを制御する
            settings["debug.openDebug"] = "openOnSessionStart";
        }
    }
}
