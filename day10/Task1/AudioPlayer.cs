using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AudioPlayer
    {
        private static AudioPlayer? _instance;
        private static readonly object _lock = new object();
        private AudioPlayer() { }
        public static AudioPlayer Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new AudioPlayer();
                }
            }
        }
        public void Play(string track)
        {
            Console.WriteLine("Воспроизведение: " + track);
        }
        public void Stop()
        {
            Console.WriteLine("Остановлено");
        }
    }
}
