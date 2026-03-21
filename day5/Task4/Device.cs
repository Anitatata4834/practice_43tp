using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Device : IPowerOn, IPowerOff
    {
        void IPowerOn.TogglePower()
        {
            Console.WriteLine("Устройство включено");
        }
        void IPowerOff.TogglePower()
        {
            Console.WriteLine("Устройство выключено");
        }
    }
}
