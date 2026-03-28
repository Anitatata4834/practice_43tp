namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();
            TVRemote remote = new TVRemote();
            while (true)
            {
                Console.WriteLine("\nПульт управления:");
                Console.WriteLine("1 - Включить телевизор");
                Console.WriteLine("2 - Выключить телевизор");
                Console.WriteLine("3 - Увеличить громкость");
                Console.WriteLine("4 - Уменьшить громкость");
                Console.WriteLine("5 - Убрать пульт");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    remote.SetCommand(new TVPowerOnCommand(tv));
                    remote.PressButton();
                }
                else if (choice == "2")
                {
                    remote.SetCommand(new TVPowerOffCommand(tv));
                    remote.PressButton();
                }
                else if (choice == "3")
                {
                    remote.SetCommand(new VolumeUpCommand(tv));
                    remote.PressButton();
                }
                else if (choice == "4")
                {
                    remote.SetCommand(new VolumeDownCommand(tv));
                    remote.PressButton();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Пульт убран");
                    break; 
                }
                else
                {
                    Console.WriteLine("Неизвестная команда");
                }
            }
        }
    }
}
