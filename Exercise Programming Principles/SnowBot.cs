namespace Exercise_Programming_Principles;

public class SnowBot : IWeatherBot
{
    private readonly BotConfig _config;

    public SnowBot(BotConfig config)
    {
        _config = config;
    }

    public void CheckWeather(WeatherData data)
    {
        if (_config.Enabled && data.Temperature < _config.TemperatureThreshold)
        {
            Console.WriteLine("SnowBot activated!");
            Console.WriteLine($"SnowBot: \"{_config.Message}\"");
        }
    }
}