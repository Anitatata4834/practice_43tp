namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor s = new TemperatureSensor();
            Console.Write("Введите температуру: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            try
            {
                s.SetTemperature(temp);
            }
            catch (TemperatureOutOfRangeException ex)
            {
                Console.WriteLine("Ошбика: " + ex.Message);
            }
        }
    }
}
