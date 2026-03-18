namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Console.Write("Введите суффикс: ");
            string suffix = Console.ReadLine();
            if (text.EndsWith(suffix))
                Console.WriteLine("Строка заканчивается на заданный суффикс");
            else
                Console.WriteLine("Строка не заканчивается на заданный суффикс");
        }
    }
}
