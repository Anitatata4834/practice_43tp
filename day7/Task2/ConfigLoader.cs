using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ConfigLoader
    {
        public void LoadConfig(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Конфигурационный файл не найден");
            }
            Console.WriteLine("Конфигурационный файл найден");
        }
    }
}
