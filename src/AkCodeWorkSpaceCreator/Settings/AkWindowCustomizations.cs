using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkCodeWorkSpaceCreator.Settings
{
    public class AkWindowCustomizations
    {
        //==========================================================================================================
        //Window: Title
        //アクティブなエディターに基づいてウィンドウのタイトルを制御します。変数はコンテキストに基づいて置き換えられます:

        //'${activeEditorShort}': ファイル名(例: myFile.txt)。
        //${activeEditorMedium
        //}: ワークスペース フォルダーに対して相対的なファイルのパス(例: myFolder/myFileFolder/myFile.txt)。
        //${activeEditorLong
        //}: ファイルの完全なパス(例: / Users / Development / myFolder / myFileFolder / myFile.txt)。
        //${ activeFolderShort}: ファイルが含まれているフォルダーの名前(例: myFileFolder)。
        //${ activeFolderMedium}: ファイルを含むフォルダーの、ワークスペースフォルダーからの相対パス(例: myFolder / myFileFolder)。
        //'${activeFolderLong}': ファイルが格納されているフォルダーのフルパス(例: / Users / Development / myFolder / myFileFolder)。
        //${ folderName}`: ファイルが含まれているワークスペース フォルダーの名前(例: myFolder)。
        //${ folderPath}: ファイルが含まれているワークスペースの絶対パスです(例: / Users / Development / myFolder)。
        //${ rootName}: 開かれたワークスペースまたはフォルダーの名前(例: myFolder または myWorkspace)。
        //${ rootPath}: 開かれたワークスペースまたはフォルダーのファイル パス(例: / Users / Development / myWorkspace)。
        //${ appName}: 例: VS Code。
        //${ remoteName}: 例: SSH
        //${ dirty}: アクティブなエディターが編集状態(ダーティー) のとき、ダーティー インジゲーターを表示します。
        //${separator}: 値か固定のテキストで囲われたとき、条件付きの区切り記号(" - ") を表示します。
        //==========================================================================================================

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="settings"></param>
        public AkWindowCustomizations(Dictionary<string, object> settings)
        {
            settings["window.title"] = @"${dirty}\${activeEditorMedium}${separator}${rootName}";
        }
    }
}
