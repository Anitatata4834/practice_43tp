using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название трека: ");
            string track = Console.ReadLine();
            AudioPlayer player = AudioPlayer.Instance;
            player.Play(track);
            Console.Write("Введите стоп чтобы остановить: ");
            Console.ReadLine();
            player.Stop();
        }
    }
}
