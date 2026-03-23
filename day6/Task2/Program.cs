namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
                num[i] = r.Next(0, 100);
            Console.WriteLine("Исходный массив: " + string.Join(", ", num));
            ArrayProcessor asc = Methods.SortAscending;
            ArrayProcessor desc = Methods.SortDescending;
            int[] sortAsc = Methods.ProcessArray(num, asc);
            int[] sortDesc = Methods.ProcessArray(num, desc);
            Console.WriteLine("По возрастанию: " + string.Join(", ", sortAsc));
            Console.WriteLine("По убыванию: " + string.Join(", ", sortDesc));
        }
    }
}
