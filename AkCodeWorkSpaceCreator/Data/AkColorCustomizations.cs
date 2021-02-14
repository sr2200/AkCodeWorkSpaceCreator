using Newtonsoft.Json;

namespace AkCodeWorkSpaceCreator.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://code.visualstudio.com/api/references/theme-color"/>
    [JsonObject]
    public class AkColorCustomizations
    {
        //"editor.background": "エディタの背景色",
        /// <summary>
        /// Gets or sets エディタの背景色.
        /// </summary>
        /// <value>
        /// エディタの背景色
        /// </value>
        [JsonProperty("editor.background")]
        public string EditorBackground { get; set; }

        //"editor.foreground": "エディタの前景色",        
        /// <summary>
        /// Gets or sets エディタの前景色
        /// </summary>
        /// <value>
        /// エディタの前景色
        /// </value>
        [JsonProperty("editor.foreground")]
        public string EditorForeground { get; set; }

        //"editorGroup.border": "複数のエディタを横に並べた時の境界線の色"
        /// <summary>
        /// Gets or sets 複数のエディタを横に並べた時の境界線の色
        /// </summary>
        /// <value>
        /// 複数のエディタを横に並べた時の境界線の色
        /// </value>
        [JsonProperty("editorGroup.border")]
        public string EditorGrouBorder { get; set; }

        //"editorLineNumber.foreground": "エディタの行番号の色"
        /// <summary>
        /// Gets or sets エディタの行番号の色
        /// </summary>
        /// <value>
        /// エディタの行番号の色
        /// </value>
        [JsonProperty("editorLineNumber.foreground")]
        public string EditorLineNumbeForeground { get; set; }

        //"editor.selectionBackground": "エディタカーソルの背景色"
        /// <summary>
        /// Gets or sets エディタカーソルの背景色
        /// </summary>
        /// <value>
        /// エディタカーソルの背景色
        /// </value>
        [JsonProperty("editor.selectionBackground")]
        public string EditoSelectionBackground { get; set; }

        //"errorForeground": "エラーメッセージの全体的な前景色"
        /// <summary>
        /// Gets or sets エラーメッセージの全体的な前景色
        /// </summary>
        /// <value>
        /// エラーメッセージの全体的な前景色
        /// </value>
        [JsonProperty("errorForeground")]
        public string ErrorForeground { get; set; }

        //"_comment1": "ボタン、バッジ"
        /// <summary>
        /// Gets or sets ボタン、バッジ
        /// </summary>
        /// <value>
        /// ボタン、バッジ
        /// </value>
        [JsonProperty("_comment1")]
        public string _comment1 { get; set; }

        //"button.background": "ボタンの背景色"
        /// <summary>
        /// Gets or sets ボタンの背景色
        /// </summary>
        /// <value>
        /// ボタンの背景色
        /// </value>
        [JsonProperty("button.background")]
        public string ButtoBackground { get; set; }

        //"badge.background": "バッジ（検索結果とかで数字が表示されるやつ）の背景色"
        /// <summary>
        /// Gets or sets バッジ（検索結果とかで数字が表示されるやつ）の背景色
        /// </summary>
        /// <value>
        /// バッジ（検索結果とかで数字が表示されるやつ）の背景色
        /// </value>
        [JsonProperty("badge.background")]
        public string BadgBackground { get; set; }

        //"_comment2": "入力制御"
        /// <summary>
        /// Gets or sets 入力制御
        /// </summary>
        /// <value>
        /// 入力制御
        /// </value>
        [JsonProperty("_comment2")]
        public string _comment2 { get; set; }

        //"input.background": "入力ボックスの背景"
        /// <summary>
        /// Gets or sets 入力ボックスの背景
        /// </summary>
        /// <value>
        /// 入力ボックスの背景
        /// </value>
        [JsonProperty("input.background")]
        public string InpuBackground { get; set; }

        //"input.border": "入力ボックスの枠線"
        /// <summary>
        /// Gets or sets 入力ボックスの枠線
        /// </summary>
        /// <value>
        /// 入力ボックスの枠線
        /// </value>
        [JsonProperty("input.border")]
        public string InpuBorder { get; set; }

        //"input.placeholderForeground": "プレースホルダ"
        /// <summary>
        /// Gets or sets プレースホルダ
        /// </summary>
        /// <value>
        /// プレースホルダ
        /// </value>
        [JsonProperty("input.placeholderForeground")]
        public string InpuPlaceholderForeground { get; set; }

        //"_comment3": "スクロールバー"
        /// <summary>
        /// Gets or sets スクロールバー
        /// </summary>
        /// <value>
        /// スクロールバー
        /// </value>
        [JsonProperty("_comment3")]
        public string _comment3 { get; set; }

        //"scrollbarSlider.background": "スクロールバー背景色"
        /// <summary>
        /// Gets or sets スクロールバー背景色
        /// </summary>
        /// <value>
        /// スクロールバー背景色
        /// </value>
        [JsonProperty("scrollbarSlider.background")]
        public string ScrollbarSlideBackground { get; set; }

        //"scrollbarSlider.hoverBackground": "ホバー時のスクロールバー背景色"
        /// <summary>
        /// Gets or sets ホバー時のスクロールバー背景色
        /// </summary>
        /// <value>
        /// ホバー時のスクロールバー背景色
        /// </value>
        [JsonProperty("scrollbarSlider.hoverBackground")]
        public string ScrollbarSlideHoverBackground { get; set; }

        //"_comment4": "下のステータスバー"
        /// <summary>
        /// Gets or sets 下のステータスバー
        /// </summary>
        /// <value>
        /// 下のステータスバー
        /// </value>
        [JsonProperty("_comment4")]
        public string _comment4 { get; set; }

        //"statusBar.background": "ワークスペースが開いていない時のステータスバー背景色"
        /// <summary>
        /// Gets or sets ワークスペースが開いていない時のステータスバー背景色
        /// </summary>
        /// <value>
        /// ワークスペースが開いていない時のステータスバー背景色
        /// </value>
        [JsonProperty("statusBar.background")]
        public string StatusBaBackground { get; set; }

        //"statusBar.foreground": "ワークスペースが開いていない時のステータスバー前景色"
        /// <summary>
        /// Gets or sets ワークスペースが開いていない時のステータスバー前景色
        /// </summary>
        /// <value>
        /// ワークスペースが開いていない時のステータスバー前景色
        /// </value>
        [JsonProperty("statusBar.foreground")]
        public string StatusBaForeground { get; set; }

        //"statusBar.noFolderBackground": "フォルダーが開いていない時のステータスバー背景色"
        /// <summary>
        /// Gets or sets フォルダーが開いていない時のステータスバー背景色
        /// </summary>
        /// <value>
        /// フォルダーが開いていない時のステータスバー背景色
        /// </value>
        [JsonProperty("statusBar.noFolderBackground")]
        public string StatusBaNoFolderBackground { get; set; }

        //"statusBar.debuggingBackground": "プログラムをデバッグしている時の背景色"
        /// <summary>
        /// Gets or sets プログラムをデバッグしている時の背景色
        /// </summary>
        /// <value>
        /// プログラムをデバッグしている時の背景色
        /// </value>
        [JsonProperty("statusBar.debuggingBackground")]
        public string StatusBaDebuggingBackground { get; set; }

        //"statusBar.border": "ステータスバーの枠線"
        /// <summary>
        /// Gets or sets ステータスバーの枠線
        /// </summary>
        /// <value>
        /// ステータスバーの枠線
        /// </value>
        [JsonProperty("statusBar.border")]
        public string StatusBaBorder { get; set; }

        //"statusBarItem.prominentBackground": "ステータスバー内で目立たせる項目に対する背景色"
        /// <summary>
        /// Gets or sets ステータスバー内で目立たせる項目に対する背景色
        /// </summary>
        /// <value>
        /// ステータスバー内で目立たせる項目に対する背景色
        /// </value>
        [JsonProperty("statusBarItem.prominentBackground")]
        public string StatusBarIteProminentBackground { get; set; }

        //"_comment5": "エクスプローラのリストやツリー"
        /// <summary>
        /// Gets or sets エクスプローラのリストやツリー
        /// </summary>
        /// <value>
        /// エクスプローラのリストやツリー
        /// </value>
        [JsonProperty("_comment5")]
        public string _comment5 { get; set; }

        //"list.activeSelectionBackground": "選択された項目のリスト/ツリー背景色"
        /// <summary>
        /// Gets or sets 選択された項目のリスト/ツリー背景色
        /// </summary>
        /// <value>
        /// 選択された項目のリスト/ツリー背景色
        /// </value>
        [JsonProperty("list.activeSelectionBackground")]
        public string LisActiveSelectionBackground { get; set; }

        //"list.hoverBackground": "ホバー時のリスト/ツリーの背景"
        /// <summary>
        /// Gets or sets ホバー時のリスト/ツリーの背景
        /// </summary>
        /// <value>
        /// ホバー時のリスト/ツリーの背景
        /// </value>
        [JsonProperty("list.hoverBackground")]
        public string LisHoverBackground { get; set; }

        //"list.invalidItemForeground": "無効な項目のリスト/ツリーの文字色"
        /// <summary>
        /// Gets or sets 無効な項目のリスト/ツリーの文字色
        /// </summary>
        /// <value>
        /// 無効な項目のリスト/ツリーの文字色
        /// </value>
        [JsonProperty("list.invalidItemForeground")]
        public string LisInvalidItemForeground { get; set; }

        //"_comment6": "アクティビティバー（左端または右端にあるバー）"
        /// <summary>
        /// Gets or sets アクティビティバー（左端または右端にあるバー）
        /// </summary>
        /// <value>
        /// アクティビティバー（左端または右端にあるバー）
        /// </value>
        [JsonProperty("_comment6")]
        public string _comment6 { get; set; }

        //"activityBar.background": "アクティビティバーの背景色"
        /// <summary>
        /// Gets or sets アクティビティバーの背景色
        /// </summary>
        /// <value>
        /// アクティビティバーの背景色
        /// </value>
        [JsonProperty("activityBar.background")]
        public string ActivityBaBackground { get; set; }

        //"activityBar.foreground": "アイコンの色"
        /// <summary>
        /// Gets or sets アイコンの色
        /// </summary>
        /// <value>
        /// アイコンの色
        /// </value>
        [JsonProperty("activityBar.foreground")]
        public string ActivityBaForeground { get; set; }

        //"activityBar.border": "アクティビティバーとサイドバーの境界線の色"
        /// <summary>
        /// Gets or sets アクティビティバーとサイドバーの境界線の色
        /// </summary>
        /// <value>
        /// アクティビティバーとサイドバーの境界線の色
        /// </value>
        [JsonProperty("activityBar.border")]
        public string ActivityBaBorder { get; set; }

        //"activityBarBadge.background": "通知バッジの背景色"
        /// <summary>
        /// Gets or sets 通知バッジの背景色
        /// </summary>
        /// <value>
        /// 通知バッジの背景色
        /// </value>
        [JsonProperty("activityBarBadge.background")]
        public string ActivityBarBadgBackground { get; set; }

        //"activityBarBadge.foreground": "通知バッジの文字色"
        /// <summary>
        /// Gets or sets 通知バッジの文字色
        /// </summary>
        /// <value>
        /// 通知バッジの文字色
        /// </value>
        [JsonProperty("activityBarBadge.foreground")]
        public string ActivityBarBadgForeground { get; set; }

        //"_comment7": "サイドバー（エクスプローラや検索のようなビュー）"
        /// <summary>
        /// Gets or sets サイドバー（エクスプローラや検索のようなビュー）
        /// </summary>
        /// <value>
        /// サイドバー（エクスプローラや検索のようなビュー）
        /// </value>
        [JsonProperty("_comment7")]
        public string _comment7 { get; set; }

        //"sideBar.background": "サイドバーの背景色"
        /// <summary>
        /// Gets or sets サイドバーの背景色
        /// </summary>
        /// <value>
        /// サイドバーの背景色
        /// </value>
        [JsonProperty("sideBar.background")]
        public string SideBaBackground { get; set; }

        //"sideBar.foreground": "サイドバーの文字色"
        /// <summary>
        /// Gets or sets サイドバーの文字色
        /// </summary>
        /// <value>
        /// サイドバーの文字色
        /// </value>
        [JsonProperty("sideBar.foreground")]
        public string SideBaForeground { get; set; }

        //"sideBar.border": "サイドバーとエディターの境界線の色"
        /// <summary>
        /// Gets or sets サイドバーとエディターの境界線の色
        /// </summary>
        /// <value>
        /// サイドバーとエディターの境界線の色
        /// </value>
        [JsonProperty("sideBar.border")]
        public string SideBaBorder { get; set; }

        //"sideBarTitle.foreground": "サイドバータイトルの前景色"
        /// <summary>
        /// Gets or sets サイドバータイトルの前景色
        /// </summary>
        /// <value>
        /// サイドバータイトルの前景色
        /// </value>
        [JsonProperty("sideBarTitle.foreground")]
        public string SideBarTitlForeground { get; set; }

        //"_comment8": "タブ"
        /// <summary>
        /// Gets or sets タブ
        /// </summary>
        /// <value>
        /// タブ
        /// </value>
        [JsonProperty("_comment8")]
        public string _comment8 { get; set; }

        //"editorGroupHeader.tabsBackground": "タブの背景色"
        /// <summary>
        /// Gets or sets タブの背景色
        /// </summary>
        /// <value>
        /// タブの背景色
        /// </value>
        [JsonProperty("editorGroupHeader.tabsBackground")]
        public string EditorGroupHeadeTabsBackground { get; set; }

        //"tab.activeBackground": "アクティブなタブの背景色"
        /// <summary>
        /// Gets or sets アクティブなタブの背景色
        /// </summary>
        /// <value>
        /// アクティブなタブの背景色
        /// </value>
        [JsonProperty("tab.activeBackground")]
        public string TaActiveBackground { get; set; }

        //"tab.activeForeground": "アクティブなタブの文字色"
        /// <summary>
        /// Gets or sets アクティブなタブの文字色
        /// </summary>
        /// <value>
        /// アクティブなタブの文字色
        /// </value>
        [JsonProperty("tab.activeForeground")]
        public string TaActiveForeground { get; set; }

        //"tab.border": "タブを区切るための境界線"
        /// <summary>
        /// Gets or sets タブを区切るための境界線
        /// </summary>
        /// <value>
        /// タブを区切るための境界線
        /// </value>
        [JsonProperty("tab.border")]
        public string TaBorder { get; set; }

        //"tab.activeBorder": "アクティブなタブの下の線"
        /// <summary>
        /// Gets or sets アクティブなタブの下の線
        /// </summary>
        /// <value>
        /// アクティブなタブの下の線
        /// </value>
        [JsonProperty("tab.activeBorder")]
        public string TaActiveBorder { get; set; }

        //"tab.inactiveBackground": "非アクティブな色の背景色"
        /// <summary>
        /// Gets or sets 非アクティブな色の背景色
        /// </summary>
        /// <value>
        /// 非アクティブな色の背景色
        /// </value>
        [JsonProperty("tab.inactiveBackground")]
        public string TaInactiveBackground { get; set; }

        //"tab.inactiveForeground": "非アクティブなタブの文字色"
        /// <summary>
        /// Gets or sets 非アクティブなタブの文字色
        /// </summary>
        /// <value>
        /// 非アクティブなタブの文字色
        /// </value>
        [JsonProperty("tab.inactiveForeground")]
        public string TaInactiveForeground { get; set; }


        public AkColorCustomizations()
        {
            _comment1 = "ボタン、バッジ";
            _comment2 = "入力制御";
            _comment3 = "スクロールバー";
            _comment4 = "下のステータスバー";
            _comment5 = "エクスプローラのリストやツリー";
            _comment6 = "アクティビティバー（左端または右端にあるバー）";
            _comment7 = "サイドバー（エクスプローラや検索のようなビュー）";
            _comment8 = "タブ";
        }

    }

}
