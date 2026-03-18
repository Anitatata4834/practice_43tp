using System.Text;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите подстроку: ");
            string s = Console.ReadLine();
            bool starts = sb.ToString().StartsWith(s);
            if (starts)
                Console.WriteLine("Начинается с подстроки");
            else
                Console.WriteLine("Не начинается с подстроки");
        }
    }
}
