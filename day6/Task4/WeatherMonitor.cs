using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class WeatherMonitor
    {
        public WeatherMonitor(WeatherStation station, DisplayPanel panel, WarningSystem warning)
        {
            station.WeatherChanged += panel.UpdateDisplay;
            station.WeatherChanged += warning.ShowWarning;
        }
    }
}
