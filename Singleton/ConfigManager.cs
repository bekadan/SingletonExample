using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ComplexSingletonExample
{
    // Thread-safe Singleton using Lazy<T>
    public sealed class ConfigManager
    {
        private static readonly Lazy<ConfigManager> instance =
        new Lazy<ConfigManager>(() => new ConfigManager());

        private Dictionary<string, string> settings;

        private ConfigManager()
        {
            LoadConfiguration();
        }

        public static ConfigManager Instance => instance.Value;

        private void LoadConfiguration()
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Loading configuration...");
            string json = File.ReadAllText("appsettings.json");
            settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public string GetSetting(string key)
        {
            return settings.ContainsKey(key) ? settings[key] : null;
        }
    }
}
