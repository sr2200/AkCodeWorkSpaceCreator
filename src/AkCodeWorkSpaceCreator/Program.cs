using AkCodeWorkSpaceCreator.Settings;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace AkCodeWorkSpaceCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var prg = new Program();
            prg.Execute(args);
        }


        private const string tempDir = "Template";
        private const string input_editorconfig = "Editorconfig.txt";
        private const string output_editorconfig = ".editorconfig";

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
            var wsFilePath = Path.Combine(currentPath, dInfo.Name + ".code-workspace");
            File.WriteAllText(wsFilePath, json);

            //.vscodeフォルダ
            var vscodeFolderPath = Path.Combine(currentPath, ".vscode");
            if (!Directory.Exists(vscodeFolderPath))
            {
                Directory.CreateDirectory(vscodeFolderPath);
            }

            //.editconfigファイル
            var asmPath = new FileInfo(Assembly.GetEntryAssembly().Location).DirectoryName;
            var edFilePath = Path.Combine(asmPath, tempDir, input_editorconfig);
            var fileContents = File.ReadAllText(edFilePath);
            edFilePath = Path.Combine(currentPath, output_editorconfig);
            File.WriteAllText(edFilePath, fileContents);
        }
    }
}
