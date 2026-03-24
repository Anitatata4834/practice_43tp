namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager m = new ConfigurationManager();
            Console.Write("Введите название конфигурационного файла: ");
            string path = Console.ReadLine();
            try
            {
                m.Load(path);
            }
            catch (ConfigurationException  ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }
    }
}
