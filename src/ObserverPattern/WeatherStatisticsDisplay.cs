using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WeatherStatisticsDisplay : IObserver, IDisplay
    {
        private WeatherData _weatherData;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherStatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Weather Statistics Display");
            Console.WriteLine($"Temperature: {_temperature} Humidity {_humidity} Presssure: {_pressure} ");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Display();
        }
    }
}
