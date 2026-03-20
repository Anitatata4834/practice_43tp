using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class MinValueCalc
    {
        public static void GetMinValue(in int a, in int b, out int minValue)
        {
            if (a < b)
            {
                minValue = a;
            }
            else
            {
                minValue = b;
            }
        }
        public static void GetMinValue(in double a, in double b, out double minValue)
        {
            if (a < b)
            {
                minValue = a;
            }
            else
            {
                minValue= b;
            }
        }
    }
}
