using System.Text.RegularExpressions;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            string result = Regex.Replace(text, @"\s+", " ");
            Console.WriteLine("Результат: " + result);
        }
    }
}
