using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var weatherStatisticsDisplay = new WeatherStatisticsDisplay(weatherData);

            weatherData.SetWeatherData(20.0f, 30.0f, 40.0f);
            weatherData.SetWeatherData(80.0f, 85.0f, 90.0f);
        }
    }
}
