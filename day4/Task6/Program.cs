namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA = 1, yA = 2;
            double xB = 4, yB = 6;
            double xC = -2, yC = 3;
            double xD = -5, yD = 1;
            double AB = Geometry.Leng(xA, yA, xB, yB);
            double AC = Geometry.Leng(xA, yA, xC, yC);
            double AD = Geometry.Leng(xA, yA, xD, yD);
            Console.WriteLine("AB = " + AB);
            Console.WriteLine("AC = " + AC);
            Console.WriteLine("AD = " + AD);
        }
    }
}
