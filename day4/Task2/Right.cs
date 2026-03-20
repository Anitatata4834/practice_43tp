using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Right
    {
        public static void AddRightDigit(int D, ref int K)
        {
            if (D < 0 || D > 9)
            {
                Console.WriteLine("Диапазон должен быть от 0 до 9");
                return;
            }
            K = K * 10 + D;
        }
    }
}
