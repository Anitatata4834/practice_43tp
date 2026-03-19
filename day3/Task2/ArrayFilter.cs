using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class ArrayFilter
    {
        public static double[] FilterGreater(double[] arr, double value)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > value)
                    count++;
            double[] res = new double[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > value)
                    res[index++] = arr[i];
            return res;
        }
    }
}
