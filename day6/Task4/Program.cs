namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            DisplayPanel panel = new DisplayPanel();
            WarningSystem warning = new WarningSystem();
            WeatherMonitor monitor = new WeatherMonitor(station, panel, warning);
            station.UpdateWeather();
        }
    }
}
