using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Cube : Shape3D
    {
        public double Side;
        public Cube(double side)
        {
            Side = side;
        }
        public override double CalculateVolume()
        {
            return Math.Pow(Side, 3);
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Куб со стороной {Side}, обьем: {CalculateVolume():F2}");
        }
    }
}
