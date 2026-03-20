namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Массив: ");
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 11);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            double avg = Average.GetAverage(arr);
            Console.WriteLine("Среднее значение: " + avg);
        }
    }
}
