using Newtonsoft.Json;
using System;
using System.IO;

namespace AkCodeWorkSpaceCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var prg = new Program();
            prg.Execute(args);
        }

        private void Execute(string[] args)
        {
            var currentPath = Environment.CurrentDirectory;
            var dInfo = new DirectoryInfo(currentPath);

            //VSCodeワークスペースファイルデータ
            var data = new AkWorkSpaceData();
            var folder = new AkFolderData();
            data.Folders.Add(folder);

            folder.Name = dInfo.Name;
            folder.Path = ".";

            //VSCodeワークスペースファイルJSONデータ
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            //VSCodeワークスペースファイル出力
            var filePath = Path.Combine(currentPath, dInfo.Name + ".code-workspace");
            File.WriteAllText(filePath, json);

            //.vscodeフォルダ
            var vscodeFolderPath = Path.Combine(currentPath, ".vscode");
            if (!Directory.Exists(vscodeFolderPath))
            {
                Directory.CreateDirectory(vscodeFolderPath);
            }
        }
    }
}
