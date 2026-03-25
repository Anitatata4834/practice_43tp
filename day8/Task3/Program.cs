namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Repository<int>();
            var searcher = new SimpleSearch<int>();
            var manager = new SearchManager<int>(r, searcher);
            Console.Write("Сколько чисел хотите добавить? ");
            int count = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            Console.Write("Числа: ");
            for (int i = 0; i < count; i++)
            {
                int value = rnd.Next(1, 101);
                Console.Write(value + "  ");
                manager.AddItem(value);
            }
            Console.Write("\nВведите число для удаления: ");
            int removeValue = Convert.ToInt32(Console.ReadLine());
            manager.RemoveItem(removeValue);
            Console.Write("\nВведите число для поиска: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int result = manager.SearchItem(target.Equals);
            manager.DisplaySearchResult(result);
            Console.WriteLine("\nСортировка по возрастанию...");
            manager.SortItems();
        }
    }
}
