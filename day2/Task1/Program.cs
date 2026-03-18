namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 9, 10, 12, 7 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Сумма чисел кратных трем: " + sum);
        }
    }
}
