namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElevatorSystem system = new ElevatorSystem();
            Console.Write("Количество запросов: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите этаж: ");
                int floor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите направление (Вверх/Вниз): ");
                string direction = Console.ReadLine();
                system.Add(new ElevatorRequest(floor, direction));
            }
            Console.WriteLine("\nВсе запросы:");
            system.Show();
            Console.Write("\nВведите этаж для поиска: ");
            int searchFloor = Convert.ToInt32(Console.ReadLine());
            system.Find(searchFloor);
            Console.WriteLine("\nОбработка следующего запроса:");
            system.Process();
            Console.WriteLine("\nОставшиеся запросы:");
            system.Show();
        }
    }
}
