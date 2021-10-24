# AkCodeWorkSpaceCreator

VSCodeのワークスペースファイル（.code-workspace）を作成します。また、「.vscode」フォルダを作成します。
配色をカスタマイズするためのテンプレートが記載されます。
ワークスペースファイル（.code-workspace）には、
作成されるファイルは以下の通り

```json
{
  "folders": [
    {
      "name": "【フォルダ名】",
      "path": "."
    }
  ],
  "settings": {
    "workbench.colorCustomizations": {
      "editor.background": null,
      "editor.foreground": null,
      "editorGroup.border": null,
      "editorLineNumber.foreground": null,
      "editor.selectionBackground": null,
      "errorForeground": null,
      "_comment1": "ボタン、バッジ",
      "button.background": null,
      "badge.background": null,
      "_comment2": "入力制御",
      "input.background": null,
      "input.border": null,
      "input.placeholderForeground": null,
      "_comment3": "スクロールバー",
      "scrollbarSlider.background": null,
      "scrollbarSlider.hoverBackground": null,
      "_comment4": "下のステータスバー",
      "statusBar.background": null,
      "statusBar.foreground": null,
      "statusBar.noFolderBackground": null,
      "statusBar.debuggingBackground": null,
      "statusBar.border": null,
      "statusBarItem.prominentBackground": null,
      "_comment5": "エクスプローラのリストやツリー",
      "list.activeSelectionBackground": null,
      "list.hoverBackground": null,
      "list.invalidItemForeground": null,
      "_comment6": "アクティビティバー（左端または右端にあるバー）",
      "activityBar.background": null,
      "activityBar.foreground": null,
      "activityBar.border": null,
      "activityBarBadge.background": null,
      "activityBarBadge.foreground": null,
      "_comment7": "サイドバー（エクスプローラや検索のようなビュー）",
      "sideBar.background": null,
      "sideBar.foreground": null,
      "sideBar.border": null,
      "sideBarTitle.foreground": null,
      "_comment8": "タブ",
      "editorGroupHeader.tabsBackground": null,
      "tab.activeBackground": null,
      "tab.activeForeground": null,
      "tab.border": null,
      "tab.activeBorder": null,
      "tab.inactiveBackground": null,
      "tab.inactiveForeground": null
    }
  },
  "extensions": {
    "recommendations": []
  }
}
```
