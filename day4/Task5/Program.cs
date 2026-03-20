namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape3D sphere = new Sphere(3);
            Shape3D cube = new Cube(2);
            sphere.DisplayInfo();
            cube.DisplayInfo();
        }
    }
}
