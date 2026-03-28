using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class VideoFile : IMediaFile
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение видео файла...");
        }
    }
}
