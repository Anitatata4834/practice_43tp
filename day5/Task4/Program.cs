namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device();
            IPowerOn powerOn = device;
            IPowerOff powerOff = device;
            powerOn.TogglePower();  
            powerOff.TogglePower();
        }
    }
}
