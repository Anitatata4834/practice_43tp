using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ConfigurationManager
    {
        public void Load(string path)
        {
            try
            {
                ConfigLoader l = new ConfigLoader();
                l.LoadConfig(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Стек вызовов: " + ex.StackTrace);
                Console.WriteLine("Внутреннее исключение: " + ex.InnerException);
                throw new ConfigurationException("Ошибка при загрузке конфигурации", ex);
            }
        }
    }
}
