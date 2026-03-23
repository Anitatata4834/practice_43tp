using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class WeatherStation
    {
        public event EventHandler<EventArgs> WeatherChanged;
        public void UpdateWeather()
        {
            Console.WriteLine("Погодная станция: погода изменилась");
            WeatherChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
