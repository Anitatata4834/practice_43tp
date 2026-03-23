using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate int[] ArrayProcessor(int[] arr);
    public class Methods
    {
        public static int[] SortAscending(int[] arr)
        {
            int[] res = (int[])arr.Clone();
            Array.Sort(res);
            return res;
        }
        public static int[] SortDescending(int[] arr)
        {
            int[] res = (int[])arr.Clone();
            Array.Sort(res);
            Array.Reverse(res);
            return res;
        }
        public static int[] ProcessArray(int[] array, ArrayProcessor processor)
        {
            return processor(array);
        }
    }
}
