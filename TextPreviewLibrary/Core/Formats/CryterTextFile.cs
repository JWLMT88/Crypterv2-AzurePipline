﻿using System.Text.Json;
using System.Drawing;
using LILO_Packager.v2.Core.Updates;
using TextPreviewLibrary.Core.Contracts;

namespace TextPreviewLibrary.Core.Formats
{
    public class CrypterTextFile : ILILOCrypterTextFile
    {
        public string FileName { get; set; }
        public Color TextColor { get; set; }
        public System.Drawing.Font TextFont { get; set; }
        public bool IsLocked { get; set; }
        public string Author { get; set; }
        public string RtfContent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
        public int WordCount => CountWords();
        public SemanticVersion version { get; set; }
        private static readonly string key = "crypertextFilev2-239949i634";

        private int CountWords()
        {
            try
            {
                return RtfContent.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            catch
            {
                throw new ArgumentException(RtfContent);
            }
        }

        public static CrypterTextFile CreateSecuredFile(CrypterTextFile cry)
        {
            var securedFile = new CrypterTextFile();
            securedFile.FileName = cry.FileName;
            securedFile.TextFont = cry.TextFont;
            securedFile.Author = cry.Author;
            securedFile.CreatedAt = cry.CreatedAt;
            securedFile.IsLocked = cry.IsLocked;
            securedFile.LastModified = cry.LastModified;
            securedFile.version = cry.version;
            securedFile.TextColor = cry.TextColor;
            securedFile.RtfContent = LILO_Packager.v2.Core.Service.Services.EncryptString(cry.RtfContent, key);

            return securedFile;
        }


        public static CrypterTextFile CreateUnsecuredTextFile(CrypterTextFile cry)
        {
            var securedFile = new CrypterTextFile();
            securedFile.FileName = cry.FileName;
            securedFile.TextFont = cry.TextFont;
            securedFile.Author = cry.Author;
            securedFile.CreatedAt = cry.CreatedAt;
            securedFile.IsLocked = cry.IsLocked;
            securedFile.LastModified = cry.LastModified;
            securedFile.version = cry.version;
            securedFile.TextColor = cry.TextColor;
            securedFile.RtfContent = LILO_Packager.v2.Core.Service.Services.DecryptString(cry.RtfContent, key);

            return securedFile;
        }

        public bool IsDifferentFrom(CrypterTextFile otherFile)
        {
            return !Equals(this, otherFile);
        }

        public static void SaveInstanceToFile(CrypterTextFile file, string filePath)
        {
            if (File.Exists(filePath))
            {
                var existingFile = LoadInstanceFromFile(filePath);
                if (!file.IsDifferentFrom(existingFile))
                {
                    return;
                }
            }

            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(file, jsonOptions);

            File.WriteAllText(filePath, json);
        }

        public static CrypterTextFile LoadInstanceFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                try
                {
                    return JsonSerializer.Deserialize<CrypterTextFile>(json) ?? new CrypterTextFile();
                }
                catch
                {
                    throw new ArgumentOutOfRangeException(nameof(json));
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}

