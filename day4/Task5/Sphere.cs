using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Sphere : Shape3D
    {
        public double Radius;
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Сфера с радиусом {Radius}, обьем: {CalculateVolume():F2}");
        }
    }
}
