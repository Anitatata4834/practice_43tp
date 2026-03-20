using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Number
    {
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            return Examination.Check(n, 2);
        }
    }
}
