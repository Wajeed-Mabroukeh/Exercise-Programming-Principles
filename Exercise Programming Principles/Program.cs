using System;
using Exercise_Programming_Principles;

class Program
{
    static void Main(string[] args)
    {
        var file =
            @"C:\Users\wajed\RiderProjects\Exercise Programming Principles\Exercise Programming Principles\botConfig.json";
       
        var config = Configuration.Load(file); // Adjust the path as necessary
        if (config == null)
        {
            Console.WriteLine("Configuration could not be loaded. Exiting the application.");
            return; // Exit the application if config is null
        }
        var weatherService = new WeatherService(config);

        while (true)
        {
            Console.Write("Enter weather data (JSON or XML): ");
            var inputData = Console.ReadLine();
            weatherService.ProcessWeatherData(inputData);
        }
    }
}