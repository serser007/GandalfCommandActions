using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WinCommandActions
{
    [Serializable]
    internal class AppSettings
    {
        private const string SettingsFilename = "settings.bin";

        public List<CommandAction> Actions = new List<CommandAction>();

        public void Save(string filename=SettingsFilename)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Flush();
                ms.Position = 0;
                File.WriteAllBytes(filename, ms.ToArray());
            }
        }

        public static AppSettings Load(string filename=SettingsFilename)
        {
            if (!File.Exists(filename))
                return null;
            using (var ms = new MemoryStream(File.ReadAllBytes(filename)))
            {
                var formatter = new BinaryFormatter();
                return (AppSettings) formatter.Deserialize(ms);
            }
        }
    }
}
