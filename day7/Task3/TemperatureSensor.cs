using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TemperatureSensor
    {
        public void SetTemperature(int temp)
        {
            if (temp < -50 || temp > 50)
            {
                throw new TemperatureOutOfRangeException("Температура выходит за пределы [-50, 50]");
            }
            Console.WriteLine("Температура успешно установлена");
        }
    }
}
