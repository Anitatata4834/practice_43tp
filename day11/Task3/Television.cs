using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Television
    {
        private int _volume = 10;
        public void PowerOn()
        {
            Console.WriteLine("Телевизор включён");
        }
        public void PowerOff()
        {
            Console.WriteLine("Телевизор выключен");
        }
        public void IncreaseVolume()
        {
            _volume++;
            Console.WriteLine("Громкость увеличена: " + _volume);
        }
        public void DecreaseVolume()
        {
            _volume--;
            Console.WriteLine("Громкость уменьшена: " + _volume);
        }
    }
}
