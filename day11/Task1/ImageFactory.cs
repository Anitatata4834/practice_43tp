using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ImageFactory : MediaFactory
    {
        public override IMediaFile CreateMedia()
        {
            return new ImageFile();
        }
    }
}
