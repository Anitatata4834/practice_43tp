using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class DiscountCalc
    {
        public static double GetDiscount(double price)
        {
            return price * 0.9;
        }
        public static double GetDiscount(double price, bool isStudent)
        {
            if (isStudent)
                return price * 0.8;
            else
                return GetDiscount(price);
        }
    }
}
