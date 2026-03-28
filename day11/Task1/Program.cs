using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Аудио");
                Console.WriteLine("2 - Видео");
                Console.WriteLine("3 - Изображение");
                Console.Write("Выберите тип файла: ");
                string choice = Console.ReadLine();
                MediaFactory factory;
                if (choice == "1")
                    factory = new AudioFactory();
                else if (choice == "2")
                    factory = new VideoFactory();
                else
                    factory = new ImageFactory();
                IMediaFile file = factory.CreateMedia();
                file.Play();
                break;
            }
        }
    }
}
