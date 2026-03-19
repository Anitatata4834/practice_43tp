using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class ArrayStats
    {
        public static double Average(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum / arr.Length;
        }
        public static double Product(double[] arr)
        {
            double p = 1;
            for (int i = 0; i < arr.Length; i++)
                p *= arr[i];
            return p;
        }
    }
}
