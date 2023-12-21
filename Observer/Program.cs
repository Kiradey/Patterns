using System;
namespace Observer
{
    class Program
    {
        static void Main()
        {
            WeatherData weatherData = new WeatherData();
            GeneralDisplay generalDisplay = new GeneralDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForengateDisplay forengateDisplay = new ForengateDisplay(weatherData);
            weatherData.SetMeasurements(50, 16, 16);
            weatherData.SetMeasurements(75, 41, 56);
            weatherData.SetMeasurements(95, 25, 77);
            Console.ReadLine();
        }
    }
}