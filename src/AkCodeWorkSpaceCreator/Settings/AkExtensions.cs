using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AkCodeWorkSpaceCreator.Settings
{
    [JsonObject]
    class AkExtensions
    {
        private const string tempDir = "Template";
        private const string extensions = "Extensions.txt";

        [JsonProperty("recommendations")]
        public List<string> Recommendations { get; set; }

        public AkExtensions()
        {
            Recommendations = new List<string>();

            var asmPath = new FileInfo(Assembly.GetEntryAssembly().Location).DirectoryName;
            var filePath = Path.Combine(asmPath, tempDir, extensions);
            var fileContents = File.ReadAllText(filePath);

            foreach (var item in fileContents.Split(Environment.NewLine))
            {
                Recommendations.Add(item);
            }
        }
    }
}