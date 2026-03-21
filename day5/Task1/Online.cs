using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Online : LearningMode
    {
        public override void GetLearningType()
        {
            Console.WriteLine("Online - обучение проходит через интернет");
        }
    }
}
