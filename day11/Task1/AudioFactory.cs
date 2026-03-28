using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AudioFactory : MediaFactory
    {
        public override IMediaFile CreateMedia()
        {
            return new AudioFile();
        }
    }
}
