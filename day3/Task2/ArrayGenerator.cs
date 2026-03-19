using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class ArrayGenerator
    {
        public static double[] Generate(int size)
        {
            Random r = new Random();
            double[] arr = new double[size];
            for (int i = 0; i < size; i++)
                arr[i] = r.NextDouble() * 10;
            return arr;
        }
    }
}
