using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private WeatherData _weatherData;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions Display");
            Console.WriteLine($"Temperature: {_temperature} Humidity: {_humidity} Pressure: {_pressure}");
        }
    }
}
