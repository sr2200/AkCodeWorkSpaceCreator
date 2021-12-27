using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkCodeWorkSpaceCreator.Settings
{
    public class AkEditorCustomizations
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="settings"></param>
        public AkEditorCustomizations(Dictionary<string, object> settings)
        {
            //ミニマップを表示する場所を制御する
            settings["editor.minimap.side"] = "left";

            //ミニマップスライダーを表示するタイミングを制御する。
            settings["editor.minimap.showSlider"] = "always";

            //ミニマップのサイズを制御する
            settings["editor.minimap.size"] = "fit";

            //エディターで空白文字を表示するかどうかを制御する
            settings["editor.renderWhitespace"] = "all";

            //エディターが現在の行をどのように強調表示するかを制御する
            settings["editor.renderLineHighlight"] = "all";

            //エディターで制御文字を表示するかどうかを制御する
            settings["editor.renderControlCharacters"] = true;

            //Emmetの候補を表示
            settings["emmet.showSuggestionsAsSnippets"] = true;

            //有効にするとTabキーを押したときにEmmit省略記法が展開される
            settings["emmet.triggerExpansionOnTab"] = true;

            //Emmetのスニペットで使用される変数
            settings["emmet.variables"] = new Dictionary<string, object>();
            ((Dictionary<string, object>)settings["emmet.variables"])["lang"] = "ja";

            //既定のフォーマッタを定義する
            settings["editor.defaultFormatter"] = "esbenp.prettier-vscode";

            //保存時の自動フォーマット設定
            settings["editor.formatOnSave"] = true;
        }
    }
}
