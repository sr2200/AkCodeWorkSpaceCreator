using Newtonsoft.Json;
using System.Collections.Generic;

namespace AkCodeWorkSpaceCreator.Settings
{
    /// <summary>
    /// ワークスペースの設定クラス
    /// </summary>
    class AkCustomSettings
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AkCustomSettings(Dictionary<string, object> settings)
        {
            //カラー設定
            new AkWorkbenchCustomizations(settings);

            //デバッグ設定
            new AkDebugCustomizations(settings);

            //ウインドウ設定
            new AkWindowCustomizations(settings);

            //エディタ設定
            new AkEditorCustomizations(settings);
        }
    }

}
