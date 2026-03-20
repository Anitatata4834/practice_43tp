using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Examination
    {
        public static bool Check(int n, int divisor)
        {
            if (divisor * divisor > n)
                return true;
            if (n % divisor == 0)
                return false;
            return Check(n, divisor + 1);
        }
    }
}
