using Newtonsoft.Json;
using System.IO;

namespace InjectorV
{
    public class Settings
    {
        public bool AutoSelectLastProcess { get; set; } = false;
        public string LastSelectedProcessName { get; set; } = "";
        public InjectionMethod DefaultInjectionMethod { get; set; } = InjectionMethod.LoadLibrary;
        public bool EnableLogging { get; set; } = true;
        public string LogFilePath { get; set; } = "injector.log";

        private static readonly string SettingsFilePath = "settings.json";

        public static Settings Load()
        {
            if (File.Exists(SettingsFilePath))
            {
                try
                {
                    string json = File.ReadAllText(SettingsFilePath);
                    return JsonConvert.DeserializeObject<Settings>(json);
                }
                catch
                {
                    return new Settings();
                }
            }
            else
            {
                return new Settings();
            }
        }

        public void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(SettingsFilePath, json);
            }
            catch
            {

            }
        }
    }
}