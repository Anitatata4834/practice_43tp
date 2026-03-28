namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRobot robot = new BasicRobot();
            while (true)
            {
                Console.Write("Текущий статус робота: " + robot.GetStatus());
                Console.WriteLine("\nВыберите улучшение:");
                Console.WriteLine("1 - Добавить голосовое управление");
                Console.WriteLine("2 - Улучшить навигацию");
                Console.WriteLine("3 - Добавить датчики");
                Console.WriteLine("4 - Завершить настройку");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                    robot = new VoiceControlDecorator(robot);
                else if (choice == "2")
                    robot = new NavigationDecorator(robot);
                else if (choice == "3")
                    robot = new SensorDecorator(robot);
                else if (choice == "4")
                    break;
                else
                    Console.WriteLine("Неизвестная команда.");
            }
            Console.WriteLine("\nИтоговая конфигурация робота:");
            Console.WriteLine(robot.GetStatus());
        }
    }
}
