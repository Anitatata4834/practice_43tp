namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < arr.Length; i++)
                Array.Reverse(arr[i]);
            Console.WriteLine("\nЗеркальный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
