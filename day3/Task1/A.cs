using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class A
    {
        public int a;
        public int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double Calc()
        {
            return 1.0 / (1 + (a + b) / 2.0);
        }
        public int DiffSquare()
        {
            return (a - b) * (a - b);
        }
    }
}
