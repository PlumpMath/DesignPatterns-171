using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WeatherData : ISubject
    {
        private float _temparature;
        private float _humidity;
        private float _pressure;
        private List<IObserver> observers;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public float GetTemparature()
        {
            return _temparature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyObersevers()
        {
            foreach (var observer in observers)
            {
                observer.Update(_temparature, _humidity, _pressure);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void SetWeatherData(float temperature, float humidity, float pressure)
        {
            _temparature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            NotifyObersevers();
        }
    }
}
