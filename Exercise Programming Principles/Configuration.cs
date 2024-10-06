namespace Exercise_Programming_Principles;

using Newtonsoft.Json;
using System.IO;

public class Configuration
{
    public Dictionary<string, BotConfig> BotConfigs { get; set; }

    public static Configuration Load(string path)
    {
        var json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<Configuration>(json);
    }
}