using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Exercise_Programming_Principles;

using System.Collections.Generic;

public class WeatherService
{
    private readonly List<IWeatherBot> _bots;

    public WeatherService(Configuration config)
    {
        _bots = new List<IWeatherBot>
        {
            new RainBot(config.BotConfigs["RainBot"]),
            new SunBot(config.BotConfigs["SunBot"]),
            new SnowBot(config.BotConfigs["SnowBot"])
        };
    }

    public void ProcessWeatherData(string inputData)
    {
        WeatherData data;

        if (inputData.Trim().StartsWith("{"))
        {
            data = JsonConvert.DeserializeObject<WeatherData>(inputData);
        }
        else
        {
            var xmlSerializer = new XmlSerializer(typeof(WeatherData));
            using var stringReader = new StringReader(inputData);
            data = (WeatherData)xmlSerializer.Deserialize(stringReader);
        }

        foreach (var bot in _bots)
        {
            bot.CheckWeather(data);
        }
    }
}